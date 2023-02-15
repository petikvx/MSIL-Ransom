namespace DnsClient.Protocol;

internal static class DnsHeader
{
	public static readonly ushort OPCodeMask = 30720;

	public static readonly ushort OPCodeShift = 11;

	public static readonly ushort RCodeMask = 15;
}
