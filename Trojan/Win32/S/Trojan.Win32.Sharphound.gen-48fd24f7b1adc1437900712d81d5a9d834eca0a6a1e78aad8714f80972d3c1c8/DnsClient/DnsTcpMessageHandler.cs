using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using DnsClient.Internal;

namespace DnsClient;

internal class DnsTcpMessageHandler : DnsMessageHandler
{
	private class ClientPool : IDisposable
	{
		public class ClientEntry
		{
			public TcpClient Client { get; }

			public IPEndPoint Endpoint { get; }

			public int StartMillis { get; set; } = Environment.TickCount & 0x7FFFFFFF;


			public int MaxLiveTime { get; set; } = 5000;


			public ClientEntry(TcpClient client, IPEndPoint endpoint)
			{
				Client = client;
				Endpoint = endpoint;
			}

			public void DisposeClient()
			{
				try
				{
					Client.Close();
				}
				catch
				{
				}
			}
		}

		private bool disposedValue;

		private readonly bool _enablePool;

		private ConcurrentQueue<ClientEntry> _clients = new ConcurrentQueue<ClientEntry>();

		private readonly IPEndPoint _endpoint;

		public ClientPool(bool enablePool, IPEndPoint endpoint)
		{
			_enablePool = enablePool;
			_endpoint = endpoint;
		}

		public async Task<ClientEntry> GetNexClient()
		{
			if (disposedValue)
			{
				throw new ObjectDisposedException("ClientPool");
			}
			ClientEntry entry = null;
			if (!_enablePool)
			{
				entry = new ClientEntry(new TcpClient(_endpoint.AddressFamily), _endpoint);
				await entry.Client.ConnectAsync(_endpoint.Address, _endpoint.Port).ConfigureAwait(continueOnCapturedContext: false);
			}
			else
			{
				while (entry == null && !TryDequeue(out entry))
				{
					entry = new ClientEntry(new TcpClient(_endpoint.AddressFamily)
					{
						LingerState = new LingerOption(enable: true, 0)
					}, _endpoint);
					await entry.Client.ConnectAsync(_endpoint.Address, _endpoint.Port).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			return entry;
		}

		public void Enqueue(ClientEntry entry)
		{
			if (disposedValue)
			{
				throw new ObjectDisposedException("ClientPool");
			}
			if (entry == null)
			{
				throw new ArgumentNullException("entry");
			}
			if (!entry.Client.Client.RemoteEndPoint!.Equals(_endpoint))
			{
				throw new ArgumentException("Invalid endpoint.");
			}
			if (_enablePool && entry.Client.Connected && entry.StartMillis + entry.MaxLiveTime >= (Environment.TickCount & 0x7FFFFFFF))
			{
				_clients.Enqueue(entry);
			}
			else
			{
				entry.DisposeClient();
			}
		}

		public bool TryDequeue(out ClientEntry entry)
		{
			if (disposedValue)
			{
				throw new ObjectDisposedException("ClientPool");
			}
			bool result;
			while ((result = _clients.TryDequeue(out entry)) && (!entry.Client.Connected || entry.StartMillis + entry.MaxLiveTime < (Environment.TickCount & 0x7FFFFFFF)))
			{
				entry.DisposeClient();
			}
			return result;
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposedValue)
			{
				return;
			}
			if (disposing)
			{
				foreach (ClientEntry client in _clients)
				{
					client.DisposeClient();
				}
				_clients = new ConcurrentQueue<ClientEntry>();
			}
			disposedValue = true;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
		}
	}

	private readonly ConcurrentDictionary<IPEndPoint, ClientPool> _pools = new ConcurrentDictionary<IPEndPoint, ClientPool>();

	public override bool IsTransientException<T>(T exception)
	{
		return false;
	}

	public override DnsResponseMessage Query(IPEndPoint endpoint, DnsRequestMessage request, TimeSpan timeout)
	{
		if (timeout.TotalMilliseconds != -1.0 && timeout.TotalMilliseconds < 2147483647.0)
		{
			using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeout))
			{
				Action onCancel = delegate
				{
				};
				return QueryAsync(endpoint, request, cancellationTokenSource.Token, delegate(Action s)
				{
					onCancel = s;
				}).WithCancellation(cancellationTokenSource.Token, onCancel).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter()
					.GetResult();
			}
		}
		return QueryAsync(endpoint, request, CancellationToken.None, delegate
		{
		}).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter().GetResult();
	}

	public override async Task<DnsResponseMessage> QueryAsync(IPEndPoint server, DnsRequestMessage request, CancellationToken cancellationToken, Action<Action> cancelationCallback)
	{
		cancellationToken.ThrowIfCancellationRequested();
		ClientPool.ClientEntry entry = null;
		ClientPool pool;
		while (!_pools.TryGetValue(server, out pool))
		{
			_pools.TryAdd(server, new ClientPool(enablePool: true, server));
		}
		cancelationCallback(delegate
		{
			if (entry != null)
			{
				entry.DisposeClient();
			}
		});
		DnsResponseMessage dnsResponseMessage = null;
		while (dnsResponseMessage == null)
		{
			entry = await pool.GetNexClient().ConfigureAwait(continueOnCapturedContext: false);
			cancellationToken.ThrowIfCancellationRequested();
			dnsResponseMessage = await QueryAsyncInternal(entry.Client, entry.Client.GetStream(), request, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (dnsResponseMessage != null)
			{
				pool.Enqueue(entry);
			}
			else
			{
				entry.DisposeClient();
			}
		}
		return dnsResponseMessage;
	}

	private async Task<DnsResponseMessage> QueryAsyncInternal(TcpClient client, NetworkStream stream, DnsRequestMessage request, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		using (PooledBytes memory = new PooledBytes(1026))
		{
			using DnsDatagramWriter writer = new DnsDatagramWriter(new ArraySegment<byte>(memory.Buffer, 2, memory.Buffer.Length - 2));
			GetRequestData(request, writer);
			int index = writer.Index;
			memory.Buffer[0] = (byte)((uint)(index >> 8) & 0xFFu);
			memory.Buffer[1] = (byte)((uint)index & 0xFFu);
			await stream.WriteAsync(memory.Buffer, 0, index + 2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (!stream.CanRead)
		{
			return null;
		}
		cancellationToken.ThrowIfCancellationRequested();
		List<DnsResponseMessage> responses = new List<DnsResponseMessage>();
		do
		{
			int length;
			try
			{
				length = (stream.ReadByte() << 8) | stream.ReadByte();
			}
			catch (Exception ex) when (ex is IOException || ex is SocketException)
			{
				break;
			}
			if (length <= 0)
			{
				break;
			}
			using PooledBytes memory = new PooledBytes(length);
			int num = 0;
			int readSize = ((length > 4096) ? 4096 : length);
			while (true)
			{
				bool flag;
				if (flag = !cancellationToken.IsCancellationRequested)
				{
					int num2 = num;
					flag = (num = num2 + await stream.ReadAsync(memory.Buffer, num, readSize).ConfigureAwait(continueOnCapturedContext: false)) < length;
				}
				if (!flag)
				{
					break;
				}
				if (num > 0)
				{
					if (num + readSize > length)
					{
						readSize = length - num;
						if (readSize <= 0)
						{
							break;
						}
					}
					continue;
				}
				return null;
			}
			DnsResponseMessage responseMessage = GetResponseMessage(new ArraySegment<byte>(memory.Buffer, 0, num));
			if (request.Header.Id != responseMessage.Header.Id)
			{
				throw new DnsResponseException("Header id mismatch.");
			}
			responses.Add(responseMessage);
		}
		while (stream.DataAvailable && !cancellationToken.IsCancellationRequested);
		return DnsResponseMessage.Combine(responses.ToArray());
	}
}
