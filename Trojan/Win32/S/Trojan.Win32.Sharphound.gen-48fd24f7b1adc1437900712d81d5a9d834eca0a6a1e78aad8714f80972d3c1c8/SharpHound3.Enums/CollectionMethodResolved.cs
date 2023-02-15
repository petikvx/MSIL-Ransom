using System;

namespace SharpHound3.Enums;

[Flags]
public enum CollectionMethodResolved
{
	None = 0,
	Group = 1,
	Sessions = 2,
	LoggedOn = 4,
	Trusts = 8,
	ACL = 0x10,
	ObjectProps = 0x20,
	RDP = 0x40,
	DCOM = 0x80,
	LocalAdmin = 0x100,
	PSRemote = 0x200,
	SPNTargets = 0x400,
	Container = 0x800,
	GPOLocalGroup = 0x1000,
	DCOnly = 0x2000,
	LocalGroups = 0x3C0
}
