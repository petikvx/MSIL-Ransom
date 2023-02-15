using System;

namespace DnsClient.Protocol;

[Flags]
internal enum DnsHeaderFlag : ushort
{
	IsCheckingDisabled = 0x10,
	IsAuthenticData = 0x20,
	FutureUse = 0x40,
	RecursionAvailable = 0x80,
	RecursionDesired = 0x100,
	ResultTruncated = 0x200,
	HasAuthorityAnswer = 0x400,
	HasQuery = 0x8000
}
