using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDirectoryResponse : IPacket
{
	public string[] Files { get; set; }

	public string[] Folders { get; set; }

	public long[] FilesSize { get; set; }

	public GetDirectoryResponse()
	{
	}

	public GetDirectoryResponse(string[] files, string[] folders, long[] filessize)
	{
		Files = files;
		Folders = folders;
		FilesSize = filessize;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
