using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DnsClient.Linux;

internal static class StringParsingHelpers
{
	internal static string ParseDnsSuffixFromResolvConfFile(string filePath)
	{
		string buffer = File.ReadAllText(filePath);
		if (!new System.IO.RowConfigReader(buffer).TryGetNextValue("search", out var value))
		{
			return string.Empty;
		}
		return value;
	}

	internal static List<IPAddress> ParseDnsAddressesFromResolvConfFile(string filePath)
	{
		string buffer = File.ReadAllText(filePath);
		System.IO.RowConfigReader rowConfigReader = new System.IO.RowConfigReader(buffer);
		List<IPAddress> list = new List<IPAddress>();
		string value = null;
		while (rowConfigReader.TryGetNextValue("nameserver", out value))
		{
			if (IPAddress.TryParse(value, out var address))
			{
				list.Add(address);
			}
		}
		return list;
	}
}
