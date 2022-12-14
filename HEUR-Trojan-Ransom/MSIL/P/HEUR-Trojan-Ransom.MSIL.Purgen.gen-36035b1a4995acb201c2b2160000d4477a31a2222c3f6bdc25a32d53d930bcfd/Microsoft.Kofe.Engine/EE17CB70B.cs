using Microsoft.VisualStudio.Debugger.Interop;

namespace Microsoft.Kofe.Engine;

internal class EE17CB70B : C368CE8F7, IDebugMessageEvent2
{
	public enum EE5245CC9
	{
		OUTPUT = 1,
		MESSAGEBOX = 2,
		REASON_EXCEPTION = 0x100
	}

	public const string BD0346BC7 = "3BDB28CF-DBD2-4D24-AF03-01072B67EB9E";

	private const uint E801E4859 = 0u;

	private string F6E164E06;

	private EE5245CC9 FBBF8F594;

	public EE17CB70B(string message, EE5245CC9 messageType)
	{
		F6E164E06 = message;
		FBBF8F594 = messageType;
	}

	public int A937763A0(uint DA707F8CF)
	{
		return 0;
	}

	public int D5E0DC268(enum_MESSAGETYPE[] DA18FBA50, out string EA7CE63EA, out uint EC3ED2748, out string CA1F9D20A, out uint DF202AAAB)
	{
		DA18FBA50[0] = (enum_MESSAGETYPE)FBBF8F594;
		EA7CE63EA = F6E164E06 + "\n";
		EC3ED2748 = 0u;
		CA1F9D20A = "";
		DF202AAAB = 0u;
		return 0;
	}
}
