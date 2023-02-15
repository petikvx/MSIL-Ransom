using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

internal static class Interop
{
	internal static class Libraries
	{
		internal const string IpHlpApi = "iphlpapi.dll";
	}

	internal static class IpHlpApi
	{
		internal struct FIXED_INFO
		{
			public const int MAX_HOSTNAME_LEN = 128;

			public const int MAX_DOMAIN_NAME_LEN = 128;

			public const int MAX_SCOPE_ID_LEN = 256;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
			public string hostName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
			public string domainName;

			public IntPtr currentDnsServer;

			public IP_ADDR_STRING DnsServerList;

			public uint nodeType;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string scopeId;

			public bool enableRouting;

			public bool enableProxy;

			public bool enableDns;
		}

		internal struct IP_ADDR_STRING
		{
			public IntPtr Next;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string IpAddress;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string IpMask;

			public uint Context;
		}

		internal const uint ERROR_SUCCESS = 0u;

		internal const uint ERROR_INVALID_FUNCTION = 1u;

		internal const uint ERROR_NO_SUCH_DEVICE = 2u;

		internal const uint ERROR_INVALID_DATA = 13u;

		internal const uint ERROR_INVALID_PARAMETER = 87u;

		internal const uint ERROR_BUFFER_OVERFLOW = 111u;

		internal const uint ERROR_INSUFFICIENT_BUFFER = 122u;

		internal const uint ERROR_NO_DATA = 232u;

		internal const uint ERROR_IO_PENDING = 997u;

		internal const uint ERROR_NOT_FOUND = 1168u;

		[DllImport("iphlpapi.dll")]
		internal static extern uint GetAdaptersAddresses(AddressFamily family, uint flags, IntPtr pReserved, IntPtr adapterAddresses, ref uint outBufLen);

		[DllImport("iphlpapi.dll", ExactSpelling = true)]
		internal static extern uint GetNetworkParams(IntPtr pFixedInfo, ref uint pOutBufLen);
	}
}
