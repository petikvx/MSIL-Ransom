using System;

namespace Orcus.Native;

[Flags]
public enum ThreadAccess
{
	TERMINATE = 1,
	SUSPEND_RESUME = 2,
	GET_CONTEXT = 8,
	SET_CONTEXT = 0x10,
	SET_INFORMATION = 0x20,
	QUERY_INFORMATION = 0x40,
	SET_THREAD_TOKEN = 0x80,
	IMPERSONATE = 0x100,
	DIRECT_IMPERSONATION = 0x200
}
