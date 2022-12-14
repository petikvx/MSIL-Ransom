using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using pfcls;
using xxx.My;

namespace xxx;

[StandardModule]
internal sealed class Mod1
{
	public static Application excelapp;

	public static Workbook wb;

	public static Worksheet excelsheet;

	public static StreamReader lr;

	public static StreamWriter wr;

	public static string[] file;

	public static string[] file1;

	public static CCpfcModelDescriptor cmodeld;

	public static IpfcModelDescriptor modeld;

	public static IpfcModel model;

	public static IpfcModel2D model2D;

	public static IpfcSolid solid;

	public static CCpfcRegenInstructions crege;

	public static IpfcRegenInstructions rege;

	public static IpfcParameterOwner paraowner;

	public static IpfcUnit punit;

	public static IpfcParameter para;

	public static IpfcParamValue paravalue;

	public static IpfcWindow win;

	public static CCpfcAsyncConnection cAC;

	public static IpfcAsyncConnection asyncConnection;

	public static IpfcSession session;

	public static int H;

	public static int L;

	public static string flay;

	public static string[] list;

	public static int SheetsCount;

	public static IDataObject iData;

	public static Bitmap bitmap;

	public static int countL;

	public static int countH;

	public static int o;

	public static string str1;

	public static int index;

	public static int ba;

	public static int TopIndex;

	public static int ppp;

	public static int t;

	public static string biaoji;

	public static string pathh;

	public static bool Saved;

	public static bool getm;

	public static Excel.Range rng;

	public static string filename;

	public static string ff;

	public static string path1;

	public static string xdpath;

	public static string path;

	public static string cswj;

	public static string bjlb1;

	public static string curloadcaserow;

	public static string curloadcaseformat;

	public static bool bcheckreport;

	public static string curxnpartname;

	public static string cshlis;

	public static string cshh;

	public static bool cureditflag;

	public static string curjmID;

	public static string curtxtfname;

	public static string Kulujing;

	public static object curvalue;

	public const string strpz = "PZ";

	public static string bb;

	public static bool Wait1;

	public static int time1;

	public static bool QDflag;

	public static string proex;

	public static string scontact;

	public static string strpath;

	static Mod1()
	{
		Guid clsid = new Guid("74D4E90E-031B-3734-8CE1-36D5730A6728");
		cmodeld = (CCpfcModelDescriptor)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("05D70445-7273-34A4-85E0-F25209826593");
		crege = (CCpfcRegenInstructions)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		o = 1;
		t = 0;
		Saved = true;
		ff = "";
		path1 = "";
		Kulujing = Directory.GetParent(Application.get_StartupPath())!.ToString() + "\\mlibs\\";
	}

	public static string toen(ref string text)
	{
		if (Operators.CompareString(text, "", false) != 0)
		{
			return Strings.LCase(Strings.Trim(text)) switch
			{
				"???????????????" => "csh", 
				"????????????" => "shili", 
				"proe??????" => "sj", 
				"proe????????????" => "geo", 
				"proe????????????" => "xx", 
				"ansys????????????" => "xn", 
				"ansys????????????" => "jh", 
				"ansys????????????" => "fa", 
				"????????????" => "lz", 
				"??????????????????" => "comb", 
				"????????????" => "lf", 
				"??????????????????" => "combf", 
				"????????????" => "rf", 
				"??????" => "q", 
				"??????" => "bl", 
				"??????" => "pz", 
				"????????????" => "zbxt", 
				"???????????????" => "fixxt", 
				"????????????" => "cqxt", 
				"??????" => "qd", 
				"??????" => "gd", 
				"?????????" => "bfg", 
				"???????????????" => "cqgss", 
				"??????????????????" => "hqz", 
				"??????" => "model", 
				"??????" => "load", 
				"??????" => "mass", 
				"??????" => "zb", 
				"??????+????????????" => "fb", 
				"??????+????????????" => "tb", 
				"??????+??????" => "cqzb", 
				"??????+????????????+??????" => "cqfb", 
				"??????+????????????+??????" => "cqtb", 
				_ => "", 
			};
		}
		return "";
	}

	public static void uplist()
	{
		checked
		{
			ppp++;
			if (ppp == 1)
			{
				MyProject.Forms.cslr.lbxh.set_TopIndex(TopIndex);
				MyProject.Forms.cslr.lbcsmc.set_TopIndex(TopIndex);
				MyProject.Forms.cslr.lbcsz.set_TopIndex(TopIndex);
				MyProject.Forms.cslr.lbccmc.set_TopIndex(TopIndex);
				MyProject.Forms.cslr.lbbz.set_TopIndex(TopIndex);
				MyProject.Forms.cslr.lba.set_TopIndex(TopIndex);
				MyProject.Forms.cslr.lbxh.set_SelectedIndex(index);
				MyProject.Forms.cslr.lbcsmc.set_SelectedIndex(index);
				MyProject.Forms.cslr.lbcsz.set_SelectedIndex(index);
				MyProject.Forms.cslr.lbccmc.set_SelectedIndex(index);
				MyProject.Forms.cslr.lbbz.set_SelectedIndex(index);
				MyProject.Forms.cslr.lba.set_SelectedIndex(index);
			}
			ppp = 0;
		}
	}

	public static void ProcessKill(ref string b)
	{
		string text = b;
		IEnumerable<Process> enumerable = from proc in Process.GetProcesses()
			where Operators.CompareString(proc.ProcessName, text, false) == 0
			select (proc);
		foreach (Process item in enumerable)
		{
			item.Kill();
		}
	}

	public static void hang(ref int H)
	{
		rng = (Excel.Range)excelsheet.Cells[1, excelsheet.Cells.Columns.Count];
		countL = rng.get_End(XlDirection.xlToLeft).Column;
		rng = (Excel.Range)excelsheet.Cells[excelsheet.Cells.Rows.Count, H];
		countH = rng.get_End(XlDirection.xlUp).Row;
	}

	public static void lie()
	{
		rng = (Excel.Range)excelsheet.Cells[1, excelsheet.Cells.Columns.Count];
		countL = rng.get_End(XlDirection.xlToLeft).Column;
	}

	public static void tuichu()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		if (!Information.IsNothing((object)wb) & !Information.IsNothing((object)excelapp))
		{
			if (!Saved)
			{
				if ((int)MessageBox.Show("?????????" + bjlb1 + " ???????????????" + cswj + " ??????????????????????????????", "????????????", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
				{
					MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " ?????????????????????" + bjlb1 + " ????????????????????????" + cswj + "???????????????"));
					wb.Save();
					try
					{
						if (excelapp.Workbooks.Count != 0)
						{
							wb.Close(Missing.Value, Missing.Value, Missing.Value);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					MyProject.Forms.Main.lslog.get_Items().Add((object)(Conversions.ToString(DateTime.Now) + " ?????????????????????" + bjlb1 + " ????????????????????????" + cswj + " ??????????????????"));
					try
					{
						if (excelapp.Workbooks.Count != 0)
						{
							wb.Close(Missing.Value, Missing.Value, Missing.Value);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			else
			{
				try
				{
					if (excelapp.Workbooks.Count != 0)
					{
						wb.Close(Missing.Value, Missing.Value, Missing.Value);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
		if (excelapp != null)
		{
			excelapp = null;
		}
	}

	public static void Writerlog()
	{
		wr = new StreamWriter(Application.get_StartupPath() + "\\??????.log", append: true, Encoding.Default);
		wr.WriteLine("--------------------------------------------------------------------------");
		checked
		{
			if (MyProject.Forms.Main.lslog.get_Items().get_Count() != 0)
			{
				int num = MyProject.Forms.Main.lslog.get_Items().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					string value = Conversions.ToString(MyProject.Forms.Main.lslog.get_Items().get_Item(i));
					wr.WriteLine(value);
				}
				wr.Close();
				wr.Dispose();
			}
		}
	}

	public static bool processExcel()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		if (Process.GetProcessesByName("excel").Length != 0)
		{
			Interaction.MsgBox((object)"???????????????EXCEL???????????????????????????????????????????????????????????????EXCEL.", (MsgBoxStyle)64, (object)"??????");
		}
		return result;
	}

	public static string toch(string enname)
	{
		return Strings.LCase(enname) switch
		{
			"csh" => "???????????????", 
			"shili" => "????????????", 
			"sj" => "proe??????", 
			"geo" => "proe????????????", 
			"xx" => "proe????????????", 
			"xn" => "ansys????????????", 
			"jh" => "ansys????????????", 
			"fa" => "ansys????????????", 
			"zb" => "??????", 
			"fb" => "??????+????????????", 
			"tb" => "??????+????????????", 
			"cqzb" => "??????+??????", 
			"cqfb" => "??????+????????????+??????", 
			"cqtb" => "??????+????????????+??????", 
			"qd" => "??????", 
			"gd" => "??????", 
			"bfg" => "?????????", 
			"cqgss" => "???????????????", 
			"hqz" => "??????????????????", 
			"lz" => "????????????", 
			"lf" => "????????????", 
			_ => "", 
		};
	}

	public static void shichu()
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			modeld = cmodeld.CreateFromFileName(Application.get_StartupPath() + "\\config\\proe40\\templl40.prt");
			IpfcSession ipfcSession = session;
			object[] array = new object[1] { modeld };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)ipfcSession, (Type)null, "RetrieveModel", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				modeld = (IpfcModelDescriptor)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(IpfcModelDescriptor));
			}
			model = (IpfcModel)obj;
			model.Display();
			win = (IpfcWindow)NewLateBinding.LateGet((object)session, (Type)null, "CurrentWindow", new object[0], (string[])null, (Type[])null, (bool[])null);
			win.Activate();
			win.Repaint();
			string text = "~ Select `main_dlg_cur` `MenuBar1`1  `File`;\\~ Select `main_dlg_cur` `File.cb_file_erase`;\\~ Close `main_dlg_cur` `MenuBar1`;\\~ Close `main_dlg_cur` `File.cb_file_erase`;\\~ Activate `main_dlg_cur` `psh_erase`;~ Activate `0_std_confirm` `OK`;\\~ Command `ProCmdModelEraseNotDisp` ;~ Activate `file_erase_nd` `ok_pb`;";
			IpfcSession ipfcSession2 = session;
			object[] array4 = new object[1] { text };
			object[] array5 = array4;
			array3 = new bool[1] { true };
			NewLateBinding.LateCall((object)ipfcSession2, (Type)null, "RunMacro", array5, (string[])null, (Type[])null, array3, true);
			if (array3[0])
			{
				text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)48, (object)"??????");
			ProjectData.ClearProjectError();
		}
	}

	public static object CheckLis(ref string path)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		if (!File.Exists(path))
		{
			Interaction.MsgBox((object)" ??????????????????????????????.lis????????????", (MsgBoxStyle)64, (object)"??????");
			bcheckreport = false;
		}
		else
		{
			bcheckreport = true;
			string text = Directory.GetParent(path)!.ToString();
			text = text.Substring(checked(text.LastIndexOf("\\") + 1));
			if (File.Exists(path))
			{
				bcheckreport = true;
				lr = new StreamReader(path, Encoding.Default);
				string text2 = "";
				while (!Information.IsNothing((object)text2))
				{
					text2 = lr.ReadLine();
					if (Information.IsNothing((object)text2))
					{
						break;
					}
					string text3 = text2;
					if (!((Operators.CompareString(text2, "???????????????", false) != 0) & (Operators.CompareString(text2, "????????????", false) != 0)))
					{
						bcheckreport = true;
						text2 = Directory.GetParent(path)!.ToString();
						arrayList.Add(text2 + "\\" + toen(ref text3));
						if (!Directory.Exists(text2 + "\\" + toen(ref text3)))
						{
							Interaction.MsgBox((object)("?????????????????????????????? " + toen(ref text3) + " ?????????"), (MsgBoxStyle)64, (object)"??????");
							bcheckreport = false;
						}
						else
						{
							bcheckreport = true;
						}
					}
				}
				lr.Close();
				lr.Dispose();
				check1(ref arrayList);
			}
			else
			{
				bcheckreport = false;
			}
		}
		arrayList.Clear();
		object result = default(object);
		return result;
	}

	public static void check1(ref ArrayList path)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			int num = path.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 > num)
				{
					return;
				}
				if (Operators.CompareString(Strings.Right(Conversions.ToString(path[num2]), 1), "\\", false) != 0)
				{
					path[num2] = Operators.ConcatenateObject(path[num2], (object)"\\");
				}
				string[] files = Directory.GetFiles(Conversions.ToString(path[num2]), "*.lis", SearchOption.TopDirectoryOnly);
				if (files.Length == 0)
				{
					break;
				}
				bcheckreport = true;
				string text = Directory.GetParent(files[0])!.ToString();
				string text2 = text.Substring(text.LastIndexOf("\\") + 1);
				if (Operators.CompareString(Strings.Right(text, 1), "\\", false) != 0)
				{
					text += "\\";
				}
				if (File.Exists(text + text2 + ".lis"))
				{
					bcheckreport = true;
					lr = new StreamReader(text + text2 + ".lis", Encoding.Default);
					string text3 = "";
					while (!Information.IsNothing((object)text3))
					{
						text3 = lr.ReadLine();
						if (Information.IsNothing((object)text3))
						{
							break;
						}
						if (!Directory.Exists(text + toen(ref text3)))
						{
							Interaction.MsgBox((object)("???????????????????????? " + text + toen(ref text3) + " ?????????"), (MsgBoxStyle)64, (object)"??????");
							bcheckreport = false;
						}
						else
						{
							bcheckreport = true;
						}
					}
					lr.Close();
					lr.Dispose();
				}
				num2++;
			}
			Interaction.MsgBox((object)"?????????????????????.lis????????????", (MsgBoxStyle)64, (object)"??????");
			bcheckreport = false;
		}
	}

	public static bool banben()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		string text = Application.get_StartupPath() + "\\config\\??????.ini";
		lr = new StreamReader(text, Encoding.Default);
		string text2 = lr.ReadLine();
		if (Operators.CompareString(Strings.Trim(text2), "", false) == 0)
		{
			Interaction.MsgBox((object)("???????????????????????????,?????????????????????????????????????????????." + text), (MsgBoxStyle)64, (object)"??????");
			result = false;
		}
		else
		{
			lr.Close();
			lr.Dispose();
			string[] array = text2.Split(new char[1] { '=' });
			if (array.Length != 2)
			{
				Interaction.MsgBox((object)("???????????????????????????,?????????????????????????????????????????????." + text), (MsgBoxStyle)64, (object)"??????");
				result = false;
			}
			else
			{
				bb = Strings.Trim(array[1].ToUpper());
				string text3 = Application.get_StartupPath() + "\\config\\" + bb;
				if (!File.Exists(text3 + "\\????????????.bmp"))
				{
					Interaction.MsgBox((object)("???????????????????????????,????????????????????????????????????." + text3), (MsgBoxStyle)64, (object)"??????");
					result = false;
				}
				else
				{
					bumen(ref bb);
					((Form)MyProject.Forms.Main).set_Text(bb + " ?????????????????????");
					((Form)MyProject.Forms.Frmj).set_Text(bb + " ?????????????????????");
					MyProject.Forms.Frmj.PB.set_ImageLocation(Application.get_StartupPath() + "\\config\\" + bb + "\\????????????.bmp");
					text3 = Application.get_StartupPath() + "\\config\\" + bb + "\\net??????.ini";
					lr = new StreamReader(text3, Encoding.Default);
					text2 = "";
					while (!Information.IsNothing((object)text2))
					{
						text2 = lr.ReadLine();
						if (Operators.CompareString(Strings.Trim(text2), "", false) == 0)
						{
							break;
						}
						string[] array2 = text2.Split(new char[1] { '=' });
						if (Operators.CompareString(array2[1].ToLower(), "false", false) != 0)
						{
							array2[1] = "True";
						}
						switch (array2[0].ToLower())
						{
						case "mlc2":
							((BaseItem)MyProject.Forms.Main.proedgkwj).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "mlc3":
							((BaseItem)MyProject.Forms.Main.proedgkjs).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "mlc4":
							((BaseItem)MyProject.Forms.Main.proedgkjg).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "fa2":
							((BaseItem)MyProject.Forms.Main.ansysqx).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn2":
							((BaseItem)MyProject.Forms.Main.ansysdxxnb).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn3":
							((BaseItem)MyProject.Forms.Main.ansysxnbll).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn4":
							((BaseItem)MyProject.Forms.Main.ansysxnzj).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn5":
							((BaseItem)MyProject.Forms.Main.ansystoword).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn6":
							((BaseItem)MyProject.Forms.Main.Jss).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn7":
							((BaseItem)MyProject.Forms.Main.BIindex).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						case "xn8":
							((BaseItem)MyProject.Forms.Main.IndexVBA).set_Visible(Conversions.ToBoolean(array2[1]));
							break;
						default:
							Interaction.MsgBox((object)("?????????net??????????????????????????????????????????" + text3 + "," + array2[0].ToLower()), (MsgBoxStyle)64, (object)"??????");
							break;
						}
					}
					lr.Close();
					lr.Dispose();
				}
			}
		}
		return result;
	}

	public static void copymblis()
	{
		((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_StartupPath() + "\\Config\\" + bb + "\\mlibs.lis", Kulujing + "\\mlibs.lis", true);
	}

	public static void bumen(ref string p)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(Application.get_StartupPath() + "\\config\\" + p + "\\??????.ini"))
		{
			lr = new StreamReader(Application.get_StartupPath() + "\\config\\" + p + "\\??????.ini", Encoding.Default);
			ff = "";
			while (!Information.IsNothing((object)ff))
			{
				ff = lr.ReadLine();
				if (Information.IsNothing((object)ff))
				{
					break;
				}
				MyProject.Forms.Frmj.Cmbm.get_Items().Add((object)ff);
			}
			lr.Close();
			lr.Dispose();
			((ComboBox)MyProject.Forms.Frmj.Cmbm).set_SelectedIndex(0);
		}
		else
		{
			Interaction.MsgBox((object)"??????.ini ???????????????????????????????????????", (MsgBoxStyle)64, (object)"???????????????");
			Application.Exit();
		}
	}

	public static bool WorkbookIsOpen(object wbname)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		Workbook workbook = default(Workbook);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 104:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0021;
						case 4:
							goto IL_0027;
						case 6:
							goto IL_002e;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_002e:
					num = 6;
					break;
					IL_0027:
					num = 4;
					flag = true;
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					workbook = excelapp.Workbooks[RuntimeHelpers.GetObjectValue(wbname)];
					goto IL_0021;
					IL_0021:
					num = 3;
					if (workbook != null)
					{
						goto IL_0027;
					}
					goto IL_002e;
					end_IL_0000_2:
					break;
				}
				num = 7;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 104;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void proetime()
	{
		string text = Application.get_StartupPath() + "\\config\\ProeTime.ini";
		if (File.Exists(text))
		{
			lr = new StreamReader(text, Encoding.Default);
			time1 = Convert.ToInt32(lr.ReadLine());
		}
	}

	public static void Jzpx(ref DataGridView datagv)
	{
		checked
		{
			int num = ((BaseCollection)datagv.get_Columns()).get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				datagv.get_Columns().get_Item(i).set_SortMode((DataGridViewColumnSortMode)0);
			}
		}
	}
}
