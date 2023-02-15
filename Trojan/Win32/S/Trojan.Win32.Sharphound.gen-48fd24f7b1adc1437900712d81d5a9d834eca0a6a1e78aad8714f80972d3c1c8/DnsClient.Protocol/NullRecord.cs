using System;
using System.Text;

namespace DnsClient.Protocol;

public class NullRecord : DnsResourceRecord
{
	public byte[] Anything { get; }

	public string AsString { get; }

	public NullRecord(ResourceRecordInfo info, byte[] anything)
		: base(info)
	{
		Anything = anything ?? throw new ArgumentNullException("anything");
		try
		{
			AsString = Encoding.UTF8.GetString(anything);
		}
		catch
		{
		}
	}

	private protected override string RecordToString()
	{
		return $"\\# {Anything.Length} {AsString}";
	}
}
