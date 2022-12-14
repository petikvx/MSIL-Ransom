using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetDirectory : IPacket
{
	public string RemotePath { get; set; }

	public GetDirectory()
	{
	}

	public GetDirectory(string remotepath)
	{
		RemotePath = remotepath;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
