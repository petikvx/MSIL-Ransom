using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace StreamBaby;

public class HttpHelper
{
	private static Random random = new Random((int)DateTime.Now.ToFileTimeUtc());

	public static string WeiboUrl = "http://weibo.com/jiushixiao";

	public static string ReadWebContent()
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.81 Safari/537.36");
			webClient.Headers.Add("Cookie", "SINAGLOBAL=1428418459836.3936.1436416240424; SUHB=08J6DV0nA_nNrA; myuid=1320238747; SUB=_2AkMhSqFcdcNhrAJSmvgXz2PlaIpPjlD1sN_xNU_sJxEzHhl_7W5lmVJrtYMqnkEJEYxU9hfkZuFwcl1d3_Dt; SUBP=0033WrSXqPxfM72wWs9jqgMF55529P9D9WWuxJ_HB7_ocSOn21iBhHgv5JpVFGxQeK.4eh-p; ULV=1444453713985:47:6:6:6076458501629.531.1444453713981:1444362319765; UOR=,,fashion.ifeng.com");
			return webClient.DownloadString("http://weibo.com/jiushixiao");
		}
		catch
		{
			return string.Empty;
		}
	}

	public static byte[] DownLoadCfgTxt()
	{
		string address = "http://123.57.239.185/cff.txt";
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		return webClient.DownloadData(address);
	}

	public static void UpLoadClientId(string userName, string clientId, string c2)
	{
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		webClient.DownloadString($"http://123.57.239.185/UpDo.ashx?type=add&userName={HttpUtility.UrlEncode(userName)}&clientId={clientId}&c2={c2}");
	}

	public static string LoadNotifyText()
	{
		string address = "http://123.57.239.185/UpDo.ashx?type=gettext";
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		return webClient.DownloadString(address);
	}

	public static string GetClientIdScore(List<string> clientIdList)
	{
		string address = "http://123.57.239.185/UpDo.ashx?type=getscore&id=" + string.Join("^", clientIdList.ToArray()) + "&t=" + random.Next(1000, 10000);
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		return webClient.DownloadString(address);
	}

	public static string GetGiveScore(string cpuId)
	{
		try
		{
			string address = $"http://123.57.239.185/UpDo.ashx?type=getgivescore&c={cpuId}";
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			return webClient.DownloadString(address);
		}
		catch
		{
			return string.Empty;
		}
	}

	public static string AddGiveScore(string cpuId, string d, string score)
	{
		try
		{
			string address = $"http://123.57.239.185/UpDo.ashx?type=addgivescore&c={cpuId}&d={d}&v={HttpUtility.UrlEncode(score)}";
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			return webClient.DownloadString(address);
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	public static string GetLastSoftVersion()
	{
		string address = "http://123.57.239.185:8081/VersionInfoManager2.aspx?type=getlastversion&softName=Fly";
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		return webClient.UploadString(address, "");
	}

	public static string DownLoadFileUrl()
	{
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
		return webClient.UploadString("http://123.57.239.185:8081/VersionInfoManager2.aspx?type=getlasturl&softName=Fly", "");
	}
}
