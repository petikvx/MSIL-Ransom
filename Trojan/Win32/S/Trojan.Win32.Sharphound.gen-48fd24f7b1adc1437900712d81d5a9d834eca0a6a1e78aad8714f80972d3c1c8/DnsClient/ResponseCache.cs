using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DnsClient.Protocol;

namespace DnsClient;

internal class ResponseCache
{
	private class ResponseEntry
	{
		public DateTimeOffset ExpiresAt { get; }

		public DateTimeOffset Created { get; }

		public double TTL { get; set; }

		public IDnsQueryResponse Response { get; }

		public bool IsExpiredFor(DateTimeOffset forDate)
		{
			return forDate >= ExpiresAt;
		}

		public ResponseEntry(IDnsQueryResponse response, double ttlInMS)
		{
			Response = response;
			TTL = ttlInMS;
			Created = DateTimeOffset.UtcNow;
			ExpiresAt = Created.AddMilliseconds(TTL);
		}
	}

	private static readonly TimeSpan s_infiniteTimeout = Timeout.InfiniteTimeSpan;

	private static readonly TimeSpan s_maxTimeout = TimeSpan.FromMilliseconds(2147483647.0);

	private static readonly int s_cleanupInterval = (int)TimeSpan.FromMinutes(10.0).TotalMilliseconds;

	private readonly ConcurrentDictionary<string, ResponseEntry> _cache = new ConcurrentDictionary<string, ResponseEntry>();

	private readonly object _cleanupLock = new object();

	private bool _cleanupRunning;

	private int _lastCleanup;

	private TimeSpan? _minimumTimeout;

	public int Count => _cache.Count;

	public bool Enabled { get; set; } = true;


	public TimeSpan? MinimumTimout
	{
		get
		{
			return _minimumTimeout;
		}
		set
		{
			if (value.HasValue && (value < TimeSpan.Zero || value > s_maxTimeout) && value != s_infiniteTimeout)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_minimumTimeout = value;
		}
	}

	public ResponseCache(bool enabled = true, TimeSpan? minimumTimout = null)
	{
		Enabled = enabled;
		MinimumTimout = minimumTimout;
	}

	public static string GetCacheKey(DnsQuestion question, NameServer server)
	{
		if (question == null)
		{
			throw new ArgumentNullException("question");
		}
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		return server.Endpoint.Address.ToString() + "#" + server.Endpoint.Port.ToString() + "_" + question.QueryName.Value + ":" + (short)question.QuestionClass + ":" + (short)question.QuestionType;
	}

	public IDnsQueryResponse Get(string key)
	{
		double? effectiveTtl;
		return Get(key, out effectiveTtl);
	}

	public IDnsQueryResponse Get(string key, out double? effectiveTtl)
	{
		effectiveTtl = null;
		if (key == null)
		{
			throw new ArgumentNullException(key);
		}
		if (!Enabled)
		{
			return null;
		}
		if (_cache.TryGetValue(key, out var value))
		{
			effectiveTtl = value.TTL;
			if (!value.IsExpiredFor(DateTimeOffset.UtcNow))
			{
				StartCleanup();
				return value.Response;
			}
			_cache.TryRemove(key, out value);
		}
		return null;
	}

	public bool Add(string key, IDnsQueryResponse response)
	{
		if (key == null)
		{
			throw new ArgumentNullException(key);
		}
		if (Enabled && response != null && !response.HasError)
		{
			IEnumerable<DnsResourceRecord> allRecords = response.AllRecords;
			if (Enumerable.Any(allRecords))
			{
				double num = (double)Enumerable.Min(allRecords, (DnsResourceRecord p) => p.InitialTimeToLive) * 1000.0;
				if (MinimumTimout == Timeout.InfiniteTimeSpan)
				{
					TimeSpan timeSpan = s_maxTimeout;
					num = timeSpan.TotalMilliseconds;
				}
				else if (MinimumTimout.HasValue && num < MinimumTimout.Value.TotalMilliseconds)
				{
					num = (long)MinimumTimout.Value.TotalMilliseconds;
				}
				if (num < 1.0)
				{
					return false;
				}
				ResponseEntry value = new ResponseEntry(response, num);
				StartCleanup();
				return _cache.TryAdd(key, value);
			}
		}
		StartCleanup();
		return false;
	}

	private static void DoCleanup(ResponseCache cache)
	{
		cache._cleanupRunning = true;
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		foreach (KeyValuePair<string, ResponseEntry> item in cache._cache)
		{
			if (item.Value.IsExpiredFor(utcNow))
			{
				cache._cache.TryRemove(item.Key, out var _);
			}
		}
		cache._cleanupRunning = false;
	}

	private void StartCleanup()
	{
		if (!Enabled)
		{
			return;
		}
		int num = Environment.TickCount & 0x7FFFFFFF;
		if (_lastCleanup + s_cleanupInterval < 0 || num + s_cleanupInterval < 0)
		{
			_lastCleanup = 0;
		}
		if (_cleanupRunning || _lastCleanup + s_cleanupInterval >= num)
		{
			return;
		}
		lock (_cleanupLock)
		{
			if (!_cleanupRunning && _lastCleanup + s_cleanupInterval < num)
			{
				_lastCleanup = num;
				Task.Factory.StartNew(delegate(object state)
				{
					DoCleanup((ResponseCache)state);
				}, this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			}
		}
	}
}
