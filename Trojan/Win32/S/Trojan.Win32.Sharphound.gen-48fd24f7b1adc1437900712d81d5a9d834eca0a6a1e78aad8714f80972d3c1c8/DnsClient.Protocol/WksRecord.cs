using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace DnsClient.Protocol;

public class WksRecord : DnsResourceRecord
{
	public IPAddress Address { get; }

	public ProtocolType Protocol { get; }

	public byte[] Bitmap { get; }

	public int[] Ports { get; }

	public WksRecord(ResourceRecordInfo info, IPAddress address, int protocol, byte[] bitmap)
		: base(info)
	{
		Address = address ?? throw new ArgumentNullException("address");
		Protocol = (ProtocolType)protocol;
		Bitmap = bitmap ?? throw new ArgumentNullException("bitmap");
		Ports = GetPorts(bitmap);
	}

	private protected override string RecordToString()
	{
		return string.Format("{0} {1} {2}", Address, Protocol, string.Join(" ", Ports));
	}

	private static int[] GetPorts(byte[] data)
	{
		int num = 0;
		int num2 = data.Length;
		List<int> list = new List<int>();
		if (data.Length == 0)
		{
			return list.ToArray();
		}
		while (num < num2)
		{
			byte b = data[num++];
			if (b == 0)
			{
				continue;
			}
			for (int num3 = 7; num3 >= 0; num3--)
			{
				if ((b & (1 << num3)) != 0)
				{
					list.Add(num * 8 - num3 - 1);
				}
			}
		}
		return list.ToArray();
	}
}
