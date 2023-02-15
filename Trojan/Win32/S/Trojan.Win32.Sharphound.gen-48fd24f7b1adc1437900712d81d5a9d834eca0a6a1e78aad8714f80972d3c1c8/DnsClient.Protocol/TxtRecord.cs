using System;
using System.Collections.Generic;
using System.Linq;

namespace DnsClient.Protocol;

public class TxtRecord : DnsResourceRecord
{
	public ICollection<string> EscapedText { get; }

	public ICollection<string> Text { get; }

	public TxtRecord(ResourceRecordInfo info, string[] values, string[] utf8Values)
		: base(info)
	{
		EscapedText = values ?? throw new ArgumentNullException("values");
		Text = utf8Values ?? throw new ArgumentNullException("utf8Values");
	}

	private protected override string RecordToString()
	{
		return string.Join(" ", Enumerable.Select(EscapedText, (string p) => "\"" + p + "\"")).Trim();
	}
}
