using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace System.Net;

public static class IpAddressExtensions
{
	public static string GetArpaName(this IPAddress ip)
	{
		byte[] addressBytes = ip.GetAddressBytes();
		Array.Reverse((Array)addressBytes);
		if (ip.AddressFamily == AddressFamily.InterNetworkV6)
		{
			return string.Concat(Enumerable.Aggregate(Enumerable.SelectMany(addressBytes, (byte b) => new int[2]
			{
				b & 0xF,
				(b >> 4) & 0xF
			}), new StringBuilder(), (StringBuilder s, int b) => s.Append(b.ToString("x")).Append(".")), "ip6.arpa.");
		}
		if (ip.AddressFamily != AddressFamily.InterNetwork)
		{
			throw new ArgumentException($"Unsupported address family '{ip.AddressFamily}'.", "ip");
		}
		return string.Join(".", addressBytes) + ".in-addr.arpa.";
	}
}
