using System;

namespace DnsClient;

public enum DnsOpCode : short
{
	Query,
	[Obsolete]
	IQuery,
	Status,
	Unassinged3,
	Notify,
	Update,
	Unassinged6,
	Unassinged7,
	Unassinged8,
	Unassinged9,
	Unassinged10,
	Unassinged11,
	Unassinged12,
	Unassinged13,
	Unassinged14,
	Unassinged15
}
