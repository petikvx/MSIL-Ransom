using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StreamBaby;

public class HttpHelper2
{
	private CookieContainer cc;

	private int index { get; set; }

	public CookieContainer CC
	{
		get
		{
			return cc;
		}
		set
		{
			cc = value;
		}
	}

	public HttpHelper2()
	{
		Random random = new Random(DateTime.Now.Millisecond);
		index = random.Next(0, 3);
		cc = new CookieContainer();
	}

	public HttpHelper2(CookieContainer cc)
	{
		Random random = new Random(DateTime.Now.Millisecond);
		index = random.Next(0, 3);
		this.cc = cc;
	}

	public Stream PostAndGetStream(string targetURL, string formData, string contentType, string referer, bool allowAutoRedirect)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(formData);
		HttpWebRequest httpWebRequest = null;
		if (targetURL.StartsWith("https", StringComparison.OrdinalIgnoreCase))
		{
			ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
			httpWebRequest = WebRequest.Create(targetURL) as HttpWebRequest;
			httpWebRequest.ProtocolVersion = HttpVersion.Version10;
		}
		else
		{
			httpWebRequest = (HttpWebRequest)WebRequest.Create(targetURL);
		}
		httpWebRequest.CookieContainer = cc;
		httpWebRequest.Method = "POST";
		if (string.IsNullOrEmpty(contentType))
		{
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		}
		else
		{
			httpWebRequest.ContentType = contentType;
		}
		httpWebRequest.Referer = referer;
		httpWebRequest.AllowAutoRedirect = allowAutoRedirect;
		httpWebRequest.ContentLength = bytes.Length;
		List<string> list = new List<string>();
		list.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E)");
		list.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; SV1; .NET CLR 2.0.1124)");
		list.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
		httpWebRequest.UserAgent = list[index];
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		cc.Add(httpWebResponse.Cookies);
		if (allowAutoRedirect && httpWebResponse.StatusCode == HttpStatusCode.Found)
		{
			targetURL = httpWebResponse.Headers["Location"];
			return GetAndGetStream(targetURL, null, referer, allowAutoRedirect);
		}
		return httpWebResponse.GetResponseStream();
	}

	public byte[] PostAndGetByte(string targetURL, string formData, string contentType, string referer, bool allowAutoRedirect)
	{
		Stream stream = PostAndGetStream(targetURL, formData, contentType, referer, allowAutoRedirect);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		stream.Seek(0L, SeekOrigin.Begin);
		return array;
	}

	public Image PostAndGetBitmap(string targetURL, string formData, string contentType, string referer, bool allowAutoRedirect)
	{
		Stream stream = PostAndGetStream(targetURL, formData, contentType, referer, allowAutoRedirect);
		return Image.FromStream(stream);
	}

	public void PostAndGetBitmap(string targetURL, string formData, string contentType, string referer, bool allowAutoRedirect, string fileName)
	{
		byte[] buffer = PostAndGetByte(targetURL, formData, contentType, referer, allowAutoRedirect);
		FileStream fileStream = new FileStream(fileName, FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.Write(buffer);
		binaryWriter.Close();
		fileStream.Close();
	}

	public string PostAndGetHtml(string targetURL, string formData, string contentType, string referer, bool allowAutoRedirect, Encoding encoding)
	{
		Stream stream = PostAndGetStream(targetURL, formData, contentType, referer, allowAutoRedirect);
		return new StreamReader(stream, encoding).ReadToEnd();
	}

	public Stream GetAndGetStream(string targetURL, string contentType, string referer, bool allowAutoRedirect)
	{
		HttpWebRequest httpWebRequest = null;
		if (targetURL.StartsWith("https", StringComparison.OrdinalIgnoreCase))
		{
			ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
			httpWebRequest = WebRequest.Create(targetURL) as HttpWebRequest;
			httpWebRequest.ProtocolVersion = HttpVersion.Version10;
		}
		else
		{
			httpWebRequest = (HttpWebRequest)WebRequest.Create(targetURL);
		}
		httpWebRequest.CookieContainer = cc;
		CC = cc;
		httpWebRequest.Method = "GET";
		httpWebRequest.ContentType = contentType;
		httpWebRequest.Referer = referer;
		httpWebRequest.AllowAutoRedirect = allowAutoRedirect;
		List<string> list = new List<string>();
		list.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E)");
		list.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; SV1; .NET CLR 2.0.1124)");
		list.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
		httpWebRequest.UserAgent = list[index];
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		cc.Add(httpWebResponse.Cookies);
		if (allowAutoRedirect && httpWebResponse.StatusCode == HttpStatusCode.Found)
		{
			targetURL = httpWebResponse.Headers["Location"];
			return GetAndGetStream(targetURL, contentType, referer, allowAutoRedirect);
		}
		return httpWebResponse.GetResponseStream();
	}

	public byte[] GetAndGetByte(string targetURL, string contentType, string referer, bool allowAutoRedirect)
	{
		Stream andGetStream = GetAndGetStream(targetURL, contentType, referer, allowAutoRedirect);
		byte[] array = new byte[andGetStream.Length];
		andGetStream.Read(array, 0, array.Length);
		andGetStream.Seek(0L, SeekOrigin.Begin);
		return array;
	}

	public Image GetAndGetBitmap(string targetURL, string contentType, string referer, bool allowAutoRedirect)
	{
		Stream andGetStream = GetAndGetStream(targetURL, contentType, referer, allowAutoRedirect: true);
		return Image.FromStream(andGetStream);
	}

	public void GetAndGetFile(string targetURL, string contentType, string referer, bool allowAutoRedirect, string fileName)
	{
		byte[] andGetByte = GetAndGetByte(targetURL, contentType, referer, allowAutoRedirect);
		FileStream fileStream = new FileStream(fileName, FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		binaryWriter.Write(andGetByte);
		binaryWriter.Close();
		fileStream.Close();
	}

	public string GetAndGetHtml(string targetURL, string contentType, string referer, bool allowAutoRedirect, Encoding encoding)
	{
		Stream andGetStream = GetAndGetStream(targetURL, contentType, referer, allowAutoRedirect);
		return new StreamReader(andGetStream, encoding).ReadToEnd();
	}

	public string Upload(string url, string file, string uploadName, NameValueCollection param)
	{
		string text = DateTime.Now.Ticks.ToString("x");
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.ContentType = "multipart/form-data; boundary=" + text;
		httpWebRequest.Method = "POST";
		httpWebRequest.Accept = "*/*";
		httpWebRequest.KeepAlive = true;
		httpWebRequest.Headers.Add("Accept-Language", "zh-cn");
		httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		httpWebRequest.CookieContainer = cc;
		Stream stream = new MemoryStream();
		if (!string.IsNullOrEmpty(file))
		{
			text = "--" + text;
			string format = text + "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}\r\n";
			foreach (string key in param.Keys)
			{
				string s = string.Format(format, key, param[key]);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				stream.Write(bytes, 0, bytes.Length);
			}
			string format2 = text + "\r\nContent-Disposition: form-data; name=\"{0}\";filename=\"{1}\"\r\nContent-Type:application/octet-stream\r\n\r\n";
			string s2 = string.Format(format2, uploadName, Path.GetFileName(file));
			byte[] bytes2 = Encoding.UTF8.GetBytes(s2);
			stream.Write(bytes2, 0, bytes2.Length);
			FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[1024];
			int num = 0;
			while ((num = fileStream.Read(array, 0, array.Length)) != 0)
			{
				stream.Write(array, 0, num);
			}
			fileStream.Close();
			byte[] bytes3 = Encoding.UTF8.GetBytes("\r\n\n" + text + "\r\nContent-Disposition: form-data; name=\"Upload\"\r\n\nSubmit Query\r\n" + text + "--");
			stream.Write(bytes3, 0, bytes3.Length);
			httpWebRequest.ContentLength = stream.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			stream.Position = 0L;
			byte[] array2 = new byte[stream.Length];
			stream.Read(array2, 0, array2.Length);
			stream.Close();
			requestStream.Write(array2, 0, array2.Length);
			requestStream.Close();
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		cc.Add(httpWebResponse.Cookies);
		return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
	}

	private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
	{
		return true;
	}
}
