using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace DnsClient;

public class NameServer
{
	public const int DefaultPort = 53;

	public static readonly IPEndPoint GooglePublicDns = new IPEndPoint(IPAddress.Parse("8.8.4.4"), 53);

	public static readonly IPEndPoint GooglePublicDns2 = new IPEndPoint(IPAddress.Parse("8.8.8.8"), 53);

	public static readonly IPEndPoint GooglePublicDnsIPv6 = new IPEndPoint(IPAddress.Parse("2001:4860:4860::8844"), 53);

	public static readonly IPEndPoint GooglePublicDns2IPv6 = new IPEndPoint(IPAddress.Parse("2001:4860:4860::8888"), 53);

	internal const string EtcResolvConfFile = "/etc/resolv.conf";

	public bool Enabled { get; internal set; } = true;


	public IPEndPoint Endpoint { get; }

	public int? SupportedUdpPayloadSize { get; internal set; }

	internal DnsRequestMessage LastSuccessfulRequest { get; set; }

	public NameServer(IPAddress endpoint)
		: this(new IPEndPoint(endpoint, 53))
	{
	}

	public NameServer(IPEndPoint endpoint)
	{
		Endpoint = endpoint ?? throw new ArgumentNullException("endpoint");
	}

	public override string ToString()
	{
		return $"{Endpoint} (Udp: {SupportedUdpPayloadSize ?? 512})";
	}

	public static ICollection<IPEndPoint> ResolveNameServers(bool skipIPv6SiteLocal = true, bool fallbackToGooglePublicDns = true)
	{
		ICollection<IPEndPoint> collection = new IPEndPoint[0];
		List<Exception> list = new List<Exception>();
		try
		{
			collection = QueryNetworkInterfaces(skipIPv6SiteLocal);
		}
		catch (Exception item)
		{
			list.Add(item);
		}
		if (list.Count > 0)
		{
			if (list.Count > 1)
			{
				throw new AggregateException("Error resolving name servers", list);
			}
			throw Enumerable.First(list);
		}
		if (collection.Count == 0 && fallbackToGooglePublicDns)
		{
			return new IPEndPoint[4] { GooglePublicDnsIPv6, GooglePublicDns2IPv6, GooglePublicDns, GooglePublicDns2 };
		}
		return collection;
	}

	private static IPEndPoint[] QueryNetworkInterfaces(bool skipIPv6SiteLocal)
	{
		HashSet<IPEndPoint> hashSet = new HashSet<IPEndPoint>();
		foreach (NetworkInterface item in Enumerable.Where(NetworkInterface.GetAllNetworkInterfaces(), (NetworkInterface p) => p.OperationalStatus == OperationalStatus.Up && p.NetworkInterfaceType != NetworkInterfaceType.Loopback))
		{
			foreach (IPAddress item2 in Enumerable.Where(item.GetIPProperties().DnsAddresses, (IPAddress i) => i.AddressFamily == AddressFamily.InterNetwork || i.AddressFamily == AddressFamily.InterNetworkV6))
			{
				if (item2.AddressFamily != AddressFamily.InterNetworkV6 || !skipIPv6SiteLocal || !item2.IsIPv6SiteLocal)
				{
					hashSet.Add(new IPEndPoint(item2, 53));
				}
			}
		}
		return Enumerable.ToArray(hashSet);
	}

	internal NameServer Clone()
	{
		return new NameServer(Endpoint)
		{
			Enabled = Enabled,
			SupportedUdpPayloadSize = SupportedUdpPayloadSize
		};
	}
}
