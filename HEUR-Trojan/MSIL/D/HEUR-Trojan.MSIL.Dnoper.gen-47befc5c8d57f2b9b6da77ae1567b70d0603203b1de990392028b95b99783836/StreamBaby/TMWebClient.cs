using System;
using System.Net;

namespace StreamBaby;

public class TMWebClient : WebClient
{
	private int _timeout;

	public int Timeout
	{
		get
		{
			return _timeout;
		}
		set
		{
			_timeout = value;
		}
	}

	public TMWebClient()
	{
		_timeout = 30000;
	}

	public TMWebClient(int timeout)
	{
		_timeout = timeout * 1000;
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		webRequest.Timeout = _timeout;
		return webRequest;
	}
}
