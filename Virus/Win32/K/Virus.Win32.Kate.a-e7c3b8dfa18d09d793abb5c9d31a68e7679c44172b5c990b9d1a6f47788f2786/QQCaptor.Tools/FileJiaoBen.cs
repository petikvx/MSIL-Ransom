using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace QQCaptor.Tools;

internal class FileJiaoBen
{
	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

	[DllImport("kernel32")]
	private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

	public string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		GetPrivateProfileString(Section, Key, NoText, stringBuilder, 1024, iniFilePath);
		return stringBuilder.ToString();
	}

	public bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
	{
		long num = WritePrivateProfileString(Section, Key, Value, iniFilePath);
		if (num == 0L)
		{
			return false;
		}
		return true;
	}

	public bool FindPark(JiaoBenInfo jbinfo, string sPark)
	{
		foreach (string sTieTiao in jbinfo.m_sTieTiaoList)
		{
			if (sTieTiao == sPark)
			{
				return true;
			}
		}
		return false;
	}

	public bool GetTimeByString(string strTime, out DateTime dt)
	{
		dt = default(DateTime);
		int num = strTime.IndexOf(":", 0);
		if (num != -1)
		{
			string text = strTime.Substring(0, num);
			string text2 = strTime.Substring(num + 1, strTime.Length - num - 1);
			if (text.Length >= 1 && text2.Length >= 1)
			{
				dt = new DateTime(2000, 1, 1, int.Parse(text), int.Parse(text2), 0);
				return true;
			}
			return false;
		}
		return false;
	}

	public bool GetChuFa(JiaoBenInfo jbinfo, DateTime now)
	{
		foreach (DateTime time in jbinfo.m_TimeList)
		{
			if (now.Hour == time.Hour && now.Minute == time.Minute)
			{
				return true;
			}
		}
		return false;
	}

	public JiaoBenInfo ReadJiaoBen(string strFilePath, string sQQNum, string sQQName)
	{
		if (!File.Exists(strFilePath))
		{
			return null;
		}
		JiaoBenInfo jiaoBenInfo = null;
		try
		{
			jiaoBenInfo = new JiaoBenInfo();
			jiaoBenInfo.sQQNum = sQQNum;
			jiaoBenInfo.sQQName = sQQName;
			jiaoBenInfo.sTime = ReadIniData("??????", "????????????", "", strFilePath);
			jiaoBenInfo.sTieTiaoCheWei = ReadIniData("??????", "??????", "", strFilePath);
			jiaoBenInfo.sHuiTing = ReadIniData("??????", "????????????????????????", "", strFilePath);
			jiaoBenInfo.sGuoDu = ReadIniData("??????", "???????????????", "", strFilePath);
			jiaoBenInfo.sTingCheShunXu = ReadIniData("??????", "????????????", "", strFilePath);
			jiaoBenInfo.sYuanDi = ReadIniData("??????", "????????????", "", strFilePath);
			jiaoBenInfo.sTingCheChang = ReadIniData("??????", "?????????", "", strFilePath);
			jiaoBenInfo.sTingCheYanShi = ReadIniData("??????", "????????????", "", strFilePath);
			jiaoBenInfo.sTime = jiaoBenInfo.sTime.Replace("???", ",");
			jiaoBenInfo.sTime = jiaoBenInfo.sTime.Replace("???", ":");
			jiaoBenInfo.sTieTiaoCheWei = jiaoBenInfo.sTieTiaoCheWei.Replace("???", ",");
			jiaoBenInfo.sTingCheShunXu = jiaoBenInfo.sTingCheShunXu.Replace("???", ",");
			jiaoBenInfo.sTingCheChang = jiaoBenInfo.sTingCheChang.Replace("???", ",");
			for (int i = 0; i < 10; i++)
			{
				string section = (i + 1).ToString();
				jiaoBenInfo.m_CheZiInfoList[i].sTingChe = ReadIniData(section, "??????", "", strFilePath);
				jiaoBenInfo.m_CheZiInfoList[i].sHuanChe = ReadIniData(section, "??????", "", strFilePath);
				jiaoBenInfo.m_CheZiInfoList[i].sCarCode = ReadIniData(section, "??????", "", strFilePath);
				jiaoBenInfo.m_CheZiInfoList[i].sColor = ReadIniData(section, "??????", "", strFilePath);
			}
			string text = "";
			string text2 = jiaoBenInfo.sTime;
			int num = -1;
			while (text2.Length > 1)
			{
				num = text2.IndexOf(",", 0);
				if (num != -1)
				{
					text = text2.Substring(0, num);
					DateTime dt = default(DateTime);
					if (GetTimeByString(text, out dt))
					{
						jiaoBenInfo.m_TimeList.Add(dt);
					}
					text2 = text2.Substring(num + 1, text2.Length - num - 1);
					continue;
				}
				text = text2;
				DateTime dt2 = default(DateTime);
				if (GetTimeByString(text, out dt2))
				{
					jiaoBenInfo.m_TimeList.Add(dt2);
				}
				break;
			}
			text = "";
			num = -1;
			string text3 = jiaoBenInfo.sTieTiaoCheWei;
			while (text3.Length > 0)
			{
				num = text3.IndexOf(",", 0);
				if (num != -1)
				{
					text = text3.Substring(0, num);
					jiaoBenInfo.m_sTieTiaoList.Add(text);
					text3 = text3.Substring(num + 1, text3.Length - num - 1);
					continue;
				}
				text = text3;
				jiaoBenInfo.m_sTieTiaoList.Add(text);
				break;
			}
			text = "";
			num = -1;
			string text4 = jiaoBenInfo.sTingCheShunXu;
			while (text4.Length > 0)
			{
				num = text4.IndexOf(",", 0);
				if (num != -1)
				{
					text = text4.Substring(0, num);
					jiaoBenInfo.m_sTingCheShunXuList.Add(text);
					text4 = text4.Substring(num + 1, text4.Length - num - 1);
					continue;
				}
				text = text4;
				jiaoBenInfo.m_sTingCheShunXuList.Add(text);
				break;
			}
			text = "";
			num = -1;
			string text5 = jiaoBenInfo.sTingCheChang;
			while (text5.Length > 0)
			{
				num = text5.IndexOf(",", 0);
				if (num != -1)
				{
					text = text5.Substring(0, num);
					jiaoBenInfo.m_sTingCheChangList.Add(text);
					text5 = text5.Substring(num + 1, text5.Length - num - 1);
					continue;
				}
				text = text5;
				jiaoBenInfo.m_sTingCheChangList.Add(text);
				return jiaoBenInfo;
			}
			return jiaoBenInfo;
		}
		catch
		{
			return jiaoBenInfo;
		}
	}

	public void WriteJiaoBen(JiaoBenInfo jbinfo, string strFilePath)
	{
		try
		{
			File.Delete(strFilePath);
			WriteIniData("??????", "????????????", jbinfo.sTime, strFilePath);
			WriteIniData("??????", "??????", jbinfo.sTieTiaoCheWei, strFilePath);
			WriteIniData("??????", "????????????????????????", jbinfo.sHuiTing, strFilePath);
			WriteIniData("??????", "???????????????", jbinfo.sGuoDu, strFilePath);
			WriteIniData("??????", "????????????", jbinfo.sTingCheShunXu, strFilePath);
			WriteIniData("??????", "????????????", jbinfo.sYuanDi, strFilePath);
			WriteIniData("??????", "?????????", jbinfo.sTingCheChang, strFilePath);
			WriteIniData("??????", "????????????", jbinfo.sTingCheYanShi, strFilePath);
			for (int i = 0; i < 10; i++)
			{
				string section = (i + 1).ToString();
				WriteIniData(section, "??????", jbinfo.m_CheZiInfoList[i].sTingChe, strFilePath);
				WriteIniData(section, "??????", jbinfo.m_CheZiInfoList[i].sHuanChe, strFilePath);
				WriteIniData(section, "??????", jbinfo.m_CheZiInfoList[i].sCarCode, strFilePath);
				WriteIniData(section, "??????", jbinfo.m_CheZiInfoList[i].sColor, strFilePath);
			}
		}
		catch
		{
		}
	}
}
