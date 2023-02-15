using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using DnsClient.Internal;

namespace DnsClient;

internal class DnsUdpMessageHandler : DnsMessageHandler
{
	private const int MaxSize = 4096;

	private static ConcurrentQueue<UdpClient> _clients = new ConcurrentQueue<UdpClient>();

	private static ConcurrentQueue<UdpClient> _clientsIPv6 = new ConcurrentQueue<UdpClient>();

	private readonly bool _enableClientQueue;

	public DnsUdpMessageHandler(bool enableClientQueue)
	{
		_enableClientQueue = enableClientQueue;
	}

	public override bool IsTransientException<T>(T exception)
	{
		if (exception is SocketException)
		{
			return true;
		}
		return false;
	}

	public override DnsResponseMessage Query(IPEndPoint server, DnsRequestMessage request, TimeSpan timeout)
	{
		UdpClient nextUdpClient = GetNextUdpClient(server.AddressFamily);
		int num = ((timeout.TotalMilliseconds >= 2147483647.0) ? (-1) : ((int)timeout.TotalMilliseconds));
		nextUdpClient.Client.ReceiveTimeout = num;
		nextUdpClient.Client.SendTimeout = num;
		bool flag = false;
		try
		{
			using (DnsDatagramWriter dnsDatagramWriter = new DnsDatagramWriter())
			{
				GetRequestData(request, dnsDatagramWriter);
				nextUdpClient.Client.SendTo(dnsDatagramWriter.Data.Array, dnsDatagramWriter.Data.Offset, dnsDatagramWriter.Data.Count, SocketFlags.None, server);
			}
			int num2 = ((nextUdpClient.Available > 4096) ? nextUdpClient.Available : 4096);
			using PooledBytes pooledBytes = new PooledBytes(num2);
			int count = nextUdpClient.Client.Receive(pooledBytes.Buffer, 0, num2, SocketFlags.None);
			DnsResponseMessage responseMessage = GetResponseMessage(new ArraySegment<byte>(pooledBytes.Buffer, 0, count));
			if (request.Header.Id != responseMessage.Header.Id)
			{
				throw new DnsResponseException("Header id mismatch.");
			}
			Enqueue(server.AddressFamily, nextUdpClient);
			return responseMessage;
		}
		catch
		{
			flag = true;
			throw;
		}
		finally
		{
			if (!_enableClientQueue || flag)
			{
				try
				{
					nextUdpClient.Close();
				}
				catch
				{
				}
			}
		}
	}

	public override async Task<DnsResponseMessage> QueryAsync(IPEndPoint server, DnsRequestMessage request, CancellationToken cancellationToken, Action<Action> cancelationCallback)
	{
		cancellationToken.ThrowIfCancellationRequested();
		UdpClient udpClient = GetNextUdpClient(server.AddressFamily);
		bool mustDispose = false;
		try
		{
			cancelationCallback(delegate
			{
				udpClient.Close();
			});
			using (DnsDatagramWriter writer = new DnsDatagramWriter())
			{
				GetRequestData(request, writer);
				await udpClient.SendAsync(writer.Data.Array, writer.Data.Count, server).ConfigureAwait(continueOnCapturedContext: false);
			}
			int length = ((udpClient.Available > 4096) ? udpClient.Available : 4096);
			using (new PooledBytes(length))
			{
				UdpReceiveResult udpReceiveResult = await udpClient.ReceiveAsync().ConfigureAwait(continueOnCapturedContext: false);
				DnsResponseMessage responseMessage = GetResponseMessage(new ArraySegment<byte>(udpReceiveResult.Buffer, 0, udpReceiveResult.Buffer.Length));
				if (request.Header.Id != responseMessage.Header.Id)
				{
					throw new DnsResponseException("Header id mismatch.");
				}
				Enqueue(server.AddressFamily, udpClient);
				return responseMessage;
			}
		}
		catch (ObjectDisposedException)
		{
			throw new TimeoutException();
		}
		catch
		{
			mustDispose = true;
			throw;
		}
		finally
		{
			if (!_enableClientQueue || mustDispose)
			{
				try
				{
					udpClient.Close();
				}
				catch
				{
				}
			}
		}
	}

	private UdpClient GetNextUdpClient(AddressFamily family)
	{
		UdpClient client = null;
		if (_enableClientQueue)
		{
			while (client == null && !TryDequeue(family, out client))
			{
				client = new UdpClient(family);
			}
		}
		else
		{
			client = new UdpClient(family);
		}
		return client;
	}

	private void Enqueue(AddressFamily family, UdpClient client)
	{
		if (_enableClientQueue)
		{
			if (family == AddressFamily.InterNetwork)
			{
				_clients.Enqueue(client);
			}
			else
			{
				_clientsIPv6.Enqueue(client);
			}
		}
	}

	private bool TryDequeue(AddressFamily family, out UdpClient client)
	{
		if (family == AddressFamily.InterNetwork)
		{
			return _clients.TryDequeue(out client);
		}
		return _clientsIPv6.TryDequeue(out client);
	}
}
