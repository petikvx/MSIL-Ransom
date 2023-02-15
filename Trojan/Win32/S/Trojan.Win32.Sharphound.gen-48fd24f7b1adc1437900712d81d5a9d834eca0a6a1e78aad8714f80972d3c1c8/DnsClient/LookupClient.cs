using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using DnsClient.Protocol.Options;

namespace DnsClient;

public class LookupClient : IDnsQuery, ILookupClient
{
	private static readonly TimeSpan s_defaultTimeout = TimeSpan.FromSeconds(5.0);

	private static readonly TimeSpan s_infiniteTimeout = System.Threading.Timeout.InfiniteTimeSpan;

	private static readonly TimeSpan s_maxTimeout = TimeSpan.FromMilliseconds(2147483647.0);

	private static readonly int s_serverHealthCheckInterval = (int)TimeSpan.FromSeconds(30.0).TotalMilliseconds;

	private static int _uniqueId = 0;

	private bool _healthCheckRunning;

	private int _lastHealthCheck;

	private readonly ResponseCache _cache;

	private readonly DnsMessageHandler _messageHandler;

	private readonly DnsMessageHandler _tcpFallbackHandler;

	private readonly ConcurrentQueue<NameServer> _endpoints;

	private readonly Random _random;

	private TimeSpan _timeout;

	public bool UseTcpFallback { get; set; }

	public bool UseTcpOnly { get; set; }

	public IReadOnlyCollection<NameServer> NameServers { get; }

	public bool EnableAuditTrail { get; set; }

	public bool Recursion { get; set; }

	public int Retries { get; set; }

	public bool ThrowDnsErrors { get; set; }

	public TimeSpan Timeout
	{
		get
		{
			return _timeout;
		}
		set
		{
			if ((value <= TimeSpan.Zero || value > s_maxTimeout) && value != s_infiniteTimeout)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_timeout = value;
		}
	}

	public bool UseCache
	{
		get
		{
			return _cache.Enabled;
		}
		set
		{
			_cache.Enabled = value;
		}
	}

	public TimeSpan? MinimumCacheTimeout
	{
		get
		{
			return _cache.MinimumTimout;
		}
		set
		{
			_cache.MinimumTimout = value;
		}
	}

	public bool UseRandomNameServer { get; set; }

	public bool ContinueOnDnsError { get; set; }

	public LookupClient()
	{
		ICollection<IPEndPoint> collection = NameServer.ResolveNameServers();
		this._002Ector((collection != null) ? Enumerable.ToArray(collection) : null);
	}

	public LookupClient(params IPAddress[] nameServers)
	{
		object nameServers2;
		if (nameServers == null)
		{
			nameServers2 = null;
		}
		else
		{
			IEnumerable<IPEndPoint> enumerable = Enumerable.Select(nameServers, (IPAddress p) => new IPEndPoint(p, 53));
			nameServers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		this._002Ector((IPEndPoint[])nameServers2);
	}

	public LookupClient(IPAddress address, int port)
		: this(new IPEndPoint(address, port))
	{
	}

	public LookupClient(params IPEndPoint[] nameServers)
	{
		object nameServers2;
		if (nameServers == null)
		{
			nameServers2 = null;
		}
		else
		{
			IEnumerable<NameServer> enumerable = Enumerable.Select(nameServers, (IPEndPoint p) => new NameServer(p));
			nameServers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		this._002Ector((NameServer[])nameServers2);
	}

	internal LookupClient(params NameServer[] nameServers)
	{
		_cache = new ResponseCache();
		_random = new Random();
		_timeout = s_defaultTimeout;
		UseTcpFallback = true;
		Recursion = true;
		Retries = 5;
		UseRandomNameServer = true;
		ContinueOnDnsError = true;
		base._002Ector();
		if (nameServers == null || nameServers.Length == 0)
		{
			throw new ArgumentException("At least one name server must be configured.", "nameServers");
		}
		NameServers = (IReadOnlyCollection<NameServer>)(object)nameServers;
		_endpoints = new ConcurrentQueue<NameServer>(NameServers);
		_messageHandler = new DnsUdpMessageHandler(enableClientQueue: true);
		_tcpFallbackHandler = new DnsTcpMessageHandler();
	}

	public IDnsQueryResponse QueryReverse(IPAddress ipAddress)
	{
		if (ipAddress == null)
		{
			throw new ArgumentNullException("ipAddress");
		}
		string arpaName = ipAddress.GetArpaName();
		return Query(arpaName, QueryType.PTR);
	}

	public Task<IDnsQueryResponse> QueryReverseAsync(IPAddress ipAddress, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ipAddress == null)
		{
			throw new ArgumentNullException("ipAddress");
		}
		string arpaName = ipAddress.GetArpaName();
		return QueryAsync(arpaName, QueryType.PTR, QueryClass.IN, cancellationToken);
	}

	public IDnsQueryResponse QueryServerReverse(IReadOnlyCollection<IPAddress> servers, IPAddress ipAddress)
	{
		object servers2;
		if (servers == null)
		{
			servers2 = null;
		}
		else
		{
			IEnumerable<IPEndPoint> enumerable = Enumerable.Select(servers, (IPAddress p) => new IPEndPoint(p, 53));
			servers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		return QueryServerReverse((IReadOnlyCollection<IPEndPoint>)servers2, ipAddress);
	}

	public IDnsQueryResponse QueryServerReverse(IReadOnlyCollection<IPEndPoint> servers, IPAddress ipAddress)
	{
		if (ipAddress == null)
		{
			throw new ArgumentNullException("ipAddress");
		}
		string arpaName = ipAddress.GetArpaName();
		return QueryServer(servers, arpaName, QueryType.PTR);
	}

	public Task<IDnsQueryResponse> QueryServerReverseAsync(IReadOnlyCollection<IPAddress> servers, IPAddress ipAddress, CancellationToken cancellationToken = default(CancellationToken))
	{
		object servers2;
		if (servers == null)
		{
			servers2 = null;
		}
		else
		{
			IEnumerable<IPEndPoint> enumerable = Enumerable.Select(servers, (IPAddress p) => new IPEndPoint(p, 53));
			servers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		return QueryServerReverseAsync((IReadOnlyCollection<IPEndPoint>)servers2, ipAddress, cancellationToken);
	}

	public Task<IDnsQueryResponse> QueryServerReverseAsync(IReadOnlyCollection<IPEndPoint> servers, IPAddress ipAddress, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ipAddress == null)
		{
			throw new ArgumentNullException("ipAddress");
		}
		string arpaName = ipAddress.GetArpaName();
		return QueryServerAsync(servers, arpaName, QueryType.PTR);
	}

	public IDnsQueryResponse Query(string query, QueryType queryType, QueryClass queryClass = QueryClass.IN)
	{
		return QueryInternal(GetNextServers(), new DnsQuestion(query, queryType, queryClass));
	}

	public Task<IDnsQueryResponse> QueryAsync(string query, QueryType queryType, QueryClass queryClass = QueryClass.IN, CancellationToken cancellationToken = default(CancellationToken))
	{
		return QueryInternalAsync(GetNextServers(), new DnsQuestion(query, queryType, queryClass), cancellationToken);
	}

	public IDnsQueryResponse QueryServer(IReadOnlyCollection<IPAddress> servers, string query, QueryType queryType, QueryClass queryClass = QueryClass.IN)
	{
		object servers2;
		if (servers == null)
		{
			servers2 = null;
		}
		else
		{
			IEnumerable<IPEndPoint> enumerable = Enumerable.Select(servers, (IPAddress p) => new IPEndPoint(p, 53));
			servers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		return QueryServer((IReadOnlyCollection<IPEndPoint>)servers2, query, queryType, queryClass);
	}

	public IDnsQueryResponse QueryServer(IReadOnlyCollection<IPEndPoint> servers, string query, QueryType queryType, QueryClass queryClass = QueryClass.IN)
	{
		object servers2;
		if (servers == null)
		{
			servers2 = null;
		}
		else
		{
			IEnumerable<NameServer> enumerable = Enumerable.Select(servers, (IPEndPoint p) => new NameServer(p));
			servers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		return QueryInternal((IReadOnlyCollection<NameServer>)servers2, new DnsQuestion(query, queryType, queryClass));
	}

	public Task<IDnsQueryResponse> QueryServerAsync(IReadOnlyCollection<IPAddress> servers, string query, QueryType queryType, QueryClass queryClass = QueryClass.IN, CancellationToken cancellationToken = default(CancellationToken))
	{
		object servers2;
		if (servers == null)
		{
			servers2 = null;
		}
		else
		{
			IEnumerable<IPEndPoint> enumerable = Enumerable.Select(servers, (IPAddress p) => new IPEndPoint(p, 53));
			servers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		return QueryServerAsync((IReadOnlyCollection<IPEndPoint>)servers2, query, queryType, queryClass, cancellationToken);
	}

	public Task<IDnsQueryResponse> QueryServerAsync(IReadOnlyCollection<IPEndPoint> servers, string query, QueryType queryType, QueryClass queryClass = QueryClass.IN, CancellationToken cancellationToken = default(CancellationToken))
	{
		object servers2;
		if (servers == null)
		{
			servers2 = null;
		}
		else
		{
			IEnumerable<NameServer> enumerable = Enumerable.Select(servers, (IPEndPoint p) => new NameServer(p));
			servers2 = ((enumerable != null) ? Enumerable.ToArray(enumerable) : null);
		}
		return QueryInternalAsync((IReadOnlyCollection<NameServer>)servers2, new DnsQuestion(query, queryType, queryClass), cancellationToken);
	}

	private IDnsQueryResponse QueryInternal(IReadOnlyCollection<NameServer> servers, DnsQuestion question, bool useCache = true)
	{
		if (question == null)
		{
			throw new ArgumentNullException("question");
		}
		DnsRequestMessage request = new DnsRequestMessage(new DnsRequestHeader(GetNextUniqueId(), Recursion, DnsOpCode.Query), question);
		DnsMessageHandler handler = (UseTcpOnly ? _tcpFallbackHandler : _messageHandler);
		return ResolveQuery(servers, handler, request, useCache);
	}

	private Task<IDnsQueryResponse> QueryInternalAsync(IReadOnlyCollection<NameServer> servers, DnsQuestion question, CancellationToken cancellationToken = default(CancellationToken), bool useCache = true)
	{
		if (question == null)
		{
			throw new ArgumentNullException("question");
		}
		DnsRequestMessage request = new DnsRequestMessage(new DnsRequestHeader(GetNextUniqueId(), Recursion, DnsOpCode.Query), question);
		DnsMessageHandler handler = (UseTcpOnly ? _tcpFallbackHandler : _messageHandler);
		return ResolveQueryAsync(servers, handler, request, useCache, null, cancellationToken);
	}

	internal IDnsQueryResponse ResolveQuery(IReadOnlyCollection<NameServer> servers, DnsMessageHandler handler, DnsRequestMessage request, bool useCache, LookupClientAudit continueAudit = null)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (servers.Count == 0)
		{
			throw new ArgumentOutOfRangeException("servers", "List of servers must not be empty.");
		}
		LookupClientAudit lookupClientAudit = continueAudit ?? new LookupClientAudit();
		DnsResponseException ex = null;
		Exception ex2 = null;
		DnsQueryResponse dnsQueryResponse = null;
		foreach (NameServer server in servers)
		{
			string key = string.Empty;
			if (_cache.Enabled && useCache)
			{
				key = ResponseCache.GetCacheKey(request.Question, server);
				IDnsQueryResponse dnsQueryResponse2 = _cache.Get(key);
				if (dnsQueryResponse2 != null)
				{
					return dnsQueryResponse2;
				}
			}
			int num = 0;
			do
			{
				num++;
				ex = null;
				ex2 = null;
				try
				{
					if (EnableAuditTrail)
					{
						lookupClientAudit.StartTimer();
					}
					DnsResponseMessage dnsResponseMessage = handler.Query(server.Endpoint, request, Timeout);
					dnsResponseMessage.Audit = lookupClientAudit;
					if (dnsResponseMessage.Header.ResultTruncated && UseTcpFallback && !handler.GetType().Equals(typeof(DnsTcpMessageHandler)))
					{
						if (EnableAuditTrail)
						{
							lookupClientAudit.AuditTruncatedRetryTcp();
						}
						return ResolveQuery((IReadOnlyCollection<NameServer>)(object)new NameServer[1] { server }, _tcpFallbackHandler, request, useCache, lookupClientAudit);
					}
					if (EnableAuditTrail)
					{
						lookupClientAudit.AuditResolveServers(servers.Count);
						lookupClientAudit.AuditResponseHeader(dnsResponseMessage.Header);
					}
					if (dnsResponseMessage.Header.ResponseCode != 0 && EnableAuditTrail)
					{
						lookupClientAudit.AuditResponseError(dnsResponseMessage.Header.ResponseCode);
					}
					HandleOptRecords(lookupClientAudit, server, dnsResponseMessage);
					DnsQueryResponse dnsQueryResponse3 = dnsResponseMessage.AsQueryResponse(server.Clone());
					if (EnableAuditTrail)
					{
						lookupClientAudit.AuditResponse();
						lookupClientAudit.AuditEnd(dnsQueryResponse3);
					}
					server.Enabled = true;
					server.LastSuccessfulRequest = request;
					dnsQueryResponse = dnsQueryResponse3;
					if (dnsResponseMessage.Header.ResponseCode != 0 && (ThrowDnsErrors || ContinueOnDnsError))
					{
						throw new DnsResponseException(dnsResponseMessage.Header.ResponseCode);
					}
					if (_cache.Enabled && useCache)
					{
						_cache.Add(key, dnsQueryResponse3);
					}
					return dnsQueryResponse3;
				}
				catch (DnsResponseException ex3)
				{
					ex3.AuditTrail = lookupClientAudit.Build(null);
					ex = ex3;
					if (!ContinueOnDnsError)
					{
						throw ex3;
					}
				}
				catch (SocketException ex4) when (ex4.SocketErrorCode == SocketError.AddressFamilyNotSupported)
				{
					DisableServer(server);
				}
				catch (Exception ex5) when (ex5 is TimeoutException || handler.IsTransientException(ex5) || ex5 is OperationCanceledException || ex5 is TaskCanceledException)
				{
					DisableServer(server);
					continue;
				}
				catch (Exception ex6)
				{
					DisableServer(server);
					lookupClientAudit.AuditException(ex6);
					ex2 = ex6;
				}
				break;
			}
			while (num <= Retries && server.Enabled);
			if (EnableAuditTrail && servers.Count > 1 && server != Enumerable.Last(servers))
			{
				lookupClientAudit.AuditRetryNextServer(server);
			}
		}
		if (ex != null && ThrowDnsErrors)
		{
			throw ex;
		}
		if (dnsQueryResponse != null)
		{
			return dnsQueryResponse;
		}
		if (ex2 != null)
		{
			throw new DnsResponseException(DnsResponseCode.Unassigned, "Unhandled exception", ex2)
			{
				AuditTrail = lookupClientAudit.Build(null)
			};
		}
		throw new DnsResponseException(DnsResponseCode.ConnectionTimeout, string.Format("No connection could be established to any of the following name servers: {0}.", string.Join(", ", NameServers)))
		{
			AuditTrail = lookupClientAudit.Build(null)
		};
	}

	internal async Task<IDnsQueryResponse> ResolveQueryAsync(IReadOnlyCollection<NameServer> servers, DnsMessageHandler handler, DnsRequestMessage request, bool useCache, LookupClientAudit continueAudit = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (servers.Count == 0)
		{
			throw new ArgumentOutOfRangeException("servers", "List of servers must not be empty.");
		}
		LookupClientAudit audit = continueAudit ?? new LookupClientAudit();
		DnsResponseException lastDnsResponseException = null;
		Exception lastException = null;
		DnsQueryResponse lastQueryResponse = null;
		Action onCancel;
		foreach (NameServer serverInfo in servers)
		{
			string cacheKey = string.Empty;
			if (_cache.Enabled && useCache)
			{
				cacheKey = ResponseCache.GetCacheKey(request.Question, serverInfo);
				IDnsQueryResponse dnsQueryResponse = _cache.Get(cacheKey);
				if (dnsQueryResponse != null)
				{
					return dnsQueryResponse;
				}
			}
			int tries = 0;
			do
			{
				tries++;
				lastDnsResponseException = null;
				lastException = null;
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					if (EnableAuditTrail)
					{
						audit.StartTimer();
					}
					onCancel = delegate
					{
					};
					Task<DnsResponseMessage> task = handler.QueryAsync(serverInfo.Endpoint, request, cancellationToken, delegate(Action cancel)
					{
						onCancel = cancel;
					});
					DnsResponseMessage dnsResponseMessage;
					if (Timeout != s_infiniteTimeout || (cancellationToken != CancellationToken.None && cancellationToken.CanBeCanceled))
					{
						CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(Timeout);
						CancellationTokenSource cancellationTokenSource2 = null;
						if (cancellationToken != CancellationToken.None)
						{
							cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(cancellationTokenSource.Token, cancellationToken);
						}
						using (cancellationTokenSource)
						{
							using (cancellationTokenSource2)
							{
								dnsResponseMessage = await task.WithCancellation((cancellationTokenSource2 ?? cancellationTokenSource).Token, onCancel).ConfigureAwait(continueOnCapturedContext: false);
							}
						}
					}
					else
					{
						dnsResponseMessage = await task.ConfigureAwait(continueOnCapturedContext: false);
					}
					dnsResponseMessage.Audit = audit;
					if (dnsResponseMessage.Header.ResultTruncated && UseTcpFallback && !handler.GetType().Equals(typeof(DnsTcpMessageHandler)))
					{
						if (EnableAuditTrail)
						{
							audit.AuditTruncatedRetryTcp();
						}
						return await ResolveQueryAsync((IReadOnlyCollection<NameServer>)(object)new NameServer[1] { serverInfo }, _tcpFallbackHandler, request, useCache, audit, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
					if (EnableAuditTrail)
					{
						audit.AuditResolveServers(servers.Count);
						audit.AuditResponseHeader(dnsResponseMessage.Header);
					}
					if (dnsResponseMessage.Header.ResponseCode != 0 && EnableAuditTrail)
					{
						audit.AuditResponseError(dnsResponseMessage.Header.ResponseCode);
					}
					HandleOptRecords(audit, serverInfo, dnsResponseMessage);
					DnsQueryResponse dnsQueryResponse2 = dnsResponseMessage.AsQueryResponse(serverInfo.Clone());
					if (EnableAuditTrail)
					{
						audit.AuditResponse();
						audit.AuditEnd(dnsQueryResponse2);
					}
					serverInfo.Enabled = true;
					lastQueryResponse = dnsQueryResponse2;
					serverInfo.LastSuccessfulRequest = request;
					if (dnsResponseMessage.Header.ResponseCode != 0 && (ThrowDnsErrors || ContinueOnDnsError))
					{
						throw new DnsResponseException(dnsResponseMessage.Header.ResponseCode);
					}
					if (_cache.Enabled && useCache)
					{
						_cache.Add(cacheKey, dnsQueryResponse2);
					}
					return dnsQueryResponse2;
				}
				catch (DnsResponseException ex)
				{
					ex.AuditTrail = audit.Build(null);
					lastDnsResponseException = ex;
					if (!ContinueOnDnsError)
					{
						throw;
					}
				}
				catch (SocketException ex2) when (ex2.SocketErrorCode == SocketError.AddressFamilyNotSupported)
				{
					DisableServer(serverInfo);
				}
				catch (Exception ex3) when (ex3 is TimeoutException || handler.IsTransientException(ex3) || ex3 is OperationCanceledException || ex3 is TaskCanceledException)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						throw new OperationCanceledException(cancellationToken);
					}
					DisableServer(serverInfo);
					continue;
				}
				catch (Exception ex4)
				{
					DisableServer(serverInfo);
					if (ex4 is AggregateException ex5)
					{
						ex5.Handle(delegate(Exception e)
						{
							if (!(e is TimeoutException) && !handler.IsTransientException(e) && !(e is OperationCanceledException) && !(e is TaskCanceledException))
							{
								return false;
							}
							if (cancellationToken.IsCancellationRequested)
							{
								throw new OperationCanceledException(cancellationToken);
							}
							return true;
						});
					}
					audit.AuditException(ex4);
					lastException = ex4;
				}
				break;
			}
			while (tries <= Retries && !cancellationToken.IsCancellationRequested && serverInfo.Enabled);
			if (EnableAuditTrail && servers.Count > 1 && serverInfo != Enumerable.Last(servers))
			{
				audit.AuditRetryNextServer(serverInfo);
			}
		}
		if (lastDnsResponseException != null && ThrowDnsErrors)
		{
			throw lastDnsResponseException;
		}
		if (lastQueryResponse == null)
		{
			if (lastException != null)
			{
				throw new DnsResponseException(DnsResponseCode.Unassigned, "Unhandled exception", lastException)
				{
					AuditTrail = audit.Build(null)
				};
			}
			throw new DnsResponseException(DnsResponseCode.ConnectionTimeout, string.Format("No connection could be established to any of the following name servers: {0}.", string.Join(", ", NameServers)))
			{
				AuditTrail = audit.Build(null)
			};
		}
		return lastQueryResponse;
	}

	private void HandleOptRecords(LookupClientAudit audit, NameServer serverInfo, DnsResponseMessage response)
	{
		OptRecord optRecord = Enumerable.FirstOrDefault(Enumerable.OfType<OptRecord>(response.Additionals));
		if (optRecord != null)
		{
			if (EnableAuditTrail)
			{
				audit.AuditOptPseudo();
			}
			serverInfo.SupportedUdpPayloadSize = optRecord.UdpSize;
			response.Additionals.Remove(optRecord);
			if (EnableAuditTrail)
			{
				audit.AuditEdnsOpt(optRecord.UdpSize, optRecord.Version, optRecord.ResponseCodeEx);
			}
		}
	}

	internal IReadOnlyCollection<NameServer> GetNextServers()
	{
		IReadOnlyCollection<NameServer> readOnlyCollection = null;
		if (_endpoints.Count > 1)
		{
			readOnlyCollection = (IReadOnlyCollection<NameServer>)(object)Enumerable.ToArray(Enumerable.Where(_endpoints, (NameServer p) => p.Enabled));
			if (readOnlyCollection.Count == 0)
			{
				readOnlyCollection = (IReadOnlyCollection<NameServer>)(object)_endpoints.ToArray();
			}
			if (UseRandomNameServer && _endpoints.TryDequeue(out var result))
			{
				_endpoints.Enqueue(result);
			}
			RunHealthCheck();
		}
		else
		{
			readOnlyCollection = (IReadOnlyCollection<NameServer>)(object)_endpoints.ToArray();
		}
		return readOnlyCollection;
	}

	private void RunHealthCheck()
	{
		int num = Environment.TickCount & 0x7FFFFFFF;
		if (_lastHealthCheck + s_serverHealthCheckInterval < 0 || num + s_serverHealthCheckInterval < 0)
		{
			_lastHealthCheck = 0;
		}
		if (!_healthCheckRunning && _lastHealthCheck + s_serverHealthCheckInterval < num)
		{
			_lastHealthCheck = num;
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(1.0));
			Task.Factory.StartNew((object state) => DoHealthCheck((CancellationToken)state), cancellationTokenSource.Token, cancellationTokenSource.Token, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}
	}

	private async Task DoHealthCheck(CancellationToken cancellationToken)
	{
		_healthCheckRunning = true;
		foreach (NameServer nameServer in NameServers)
		{
			if (!nameServer.Enabled && nameServer.LastSuccessfulRequest != null)
			{
				try
				{
					await QueryInternalAsync((IReadOnlyCollection<NameServer>)(object)new NameServer[1] { nameServer }, nameServer.LastSuccessfulRequest.Question, cancellationToken, useCache: false);
				}
				catch
				{
				}
			}
		}
		_healthCheckRunning = false;
	}

	private void DisableServer(NameServer server)
	{
		if (NameServers.Count > 1)
		{
			server.Enabled = false;
		}
	}

	private ushort GetNextUniqueId()
	{
		if (_uniqueId == 65535 || _uniqueId == 0)
		{
			_uniqueId = (ushort)_random.Next(32767);
		}
		return (ushort)Interlocked.Increment(ref _uniqueId);
	}
}
