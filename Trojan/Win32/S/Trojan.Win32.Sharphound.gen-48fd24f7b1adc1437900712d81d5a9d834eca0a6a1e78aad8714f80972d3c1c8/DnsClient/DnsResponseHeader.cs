using System;
using System.Linq;
using DnsClient.Protocol;

namespace DnsClient;

public class DnsResponseHeader
{
	private readonly ushort _flags;

	public int AdditionalCount { get; }

	public int AnswerCount { get; }

	public bool FutureUse => HasFlag(DnsHeaderFlag.FutureUse);

	public bool HasAuthorityAnswer => HasFlag(DnsHeaderFlag.HasAuthorityAnswer);

	internal DnsHeaderFlag HeaderFlags => (DnsHeaderFlag)_flags;

	public int Id { get; }

	public bool IsAuthenticData => HasFlag(DnsHeaderFlag.IsAuthenticData);

	public bool IsCheckingDisabled => HasFlag(DnsHeaderFlag.IsCheckingDisabled);

	public bool HasQuery => HasFlag(DnsHeaderFlag.HasQuery);

	public int NameServerCount { get; }

	public DnsOpCode OPCode => (DnsOpCode)((DnsHeader.OPCodeMask & _flags) >> (int)DnsHeader.OPCodeShift);

	public int QuestionCount { get; }

	public bool RecursionAvailable => HasFlag(DnsHeaderFlag.RecursionAvailable);

	public DnsResponseCode ResponseCode => (DnsResponseCode)(_flags & DnsHeader.RCodeMask);

	public bool ResultTruncated => HasFlag(DnsHeaderFlag.ResultTruncated);

	public bool RecursionDesired => HasFlag(DnsHeaderFlag.RecursionDesired);

	[CLSCompliant(false)]
	public DnsResponseHeader(int id, ushort flags, int questionCount, int answerCount, int additionalCount, int serverCount)
	{
		Id = id;
		_flags = flags;
		QuestionCount = questionCount;
		AnswerCount = answerCount;
		AdditionalCount = additionalCount;
		NameServerCount = serverCount;
	}

	private bool HasFlag(DnsHeaderFlag flag)
	{
		return (HeaderFlags & flag) != 0;
	}

	public override string ToString()
	{
		string arg = $";; ->>HEADER<<- opcode: {OPCode}, status: {DnsResponseCodeText.GetErrorText(ResponseCode)}, id: {Id}";
		string[] source = new string[7]
		{
			HasQuery ? "qr" : "",
			HasAuthorityAnswer ? "aa" : "",
			RecursionDesired ? "rd" : "",
			RecursionAvailable ? "ra" : "",
			ResultTruncated ? "tc" : "",
			IsCheckingDisabled ? "cd" : "",
			IsAuthenticData ? "ad" : ""
		};
		string arg2 = string.Join(" ", Enumerable.Where(source, (string p) => p != ""));
		return $"{arg}\r\n;; flags: {arg2}; QUERY: {QuestionCount}, " + $"ANSWER: {AnswerCount}, AUTORITY: {NameServerCount}, ADDITIONAL: {AdditionalCount}";
	}
}
