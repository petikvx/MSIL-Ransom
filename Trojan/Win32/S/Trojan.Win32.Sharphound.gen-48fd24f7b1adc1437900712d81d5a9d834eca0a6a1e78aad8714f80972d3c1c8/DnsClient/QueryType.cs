using System;

namespace DnsClient;

public enum QueryType : short
{
	A = 1,
	NS = 2,
	[Obsolete("Use MX")]
	MD = 3,
	[Obsolete("Use MX")]
	MF = 4,
	CNAME = 5,
	SOA = 6,
	MB = 7,
	MG = 8,
	MR = 9,
	NULL = 10,
	WKS = 11,
	PTR = 12,
	HINFO = 13,
	MINFO = 14,
	MX = 15,
	TXT = 16,
	RP = 17,
	AFSDB = 18,
	AAAA = 28,
	SRV = 33,
	RRSIG = 46,
	AXFR = 252,
	ANY = 255,
	URI = 256,
	CAA = 257,
	SSHFP = 44
}