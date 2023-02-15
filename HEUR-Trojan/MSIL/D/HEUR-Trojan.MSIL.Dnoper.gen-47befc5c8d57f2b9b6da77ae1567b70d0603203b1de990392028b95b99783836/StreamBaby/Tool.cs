using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace StreamBaby;

public class Tool
{
	public static DateTime GetCurrentTime()
	{
		try
		{
			string address = "http://open.baidu.com/special/time/?" + (int)Math.Abs(DateTime.Now.ToFileTimeUtc());
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string input = webClient.DownloadString(address);
			Regex regex = new Regex("baidu_time\\((?<time>\\d+)\\);");
			string value = regex.Match(input).Groups["time"].Value;
			long num = Convert.ToInt64(value);
			return DateTime.Parse("1970-1-1").AddHours(8.0).AddMilliseconds(num);
		}
		catch
		{
			return DateTime.Now;
		}
	}
}
