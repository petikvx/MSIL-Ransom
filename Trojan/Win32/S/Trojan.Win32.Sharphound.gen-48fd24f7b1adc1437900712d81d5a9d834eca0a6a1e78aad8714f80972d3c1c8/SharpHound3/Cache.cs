using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Newtonsoft.Json;
using SharpHound3.Enums;

namespace SharpHound3;

internal class Cache
{
	[JsonProperty]
	private ConcurrentDictionary<string, ResolvedPrincipal> _resolvedPrincipalDictionary;

	[JsonProperty]
	private ConcurrentDictionary<string, string[]> _globalCatalogDictionary;

	[JsonProperty]
	private ConcurrentDictionary<string, LdapTypeEnum> _sidTypeDictionary;

	[JsonProperty]
	[JsonConverter(typeof(AccountCacheConverter))]
	private ConcurrentDictionary<UserDomainKey, ResolvedPrincipal> _resolvedAccountNameDictionary;

	[JsonIgnore]
	private readonly Mutex _bhMutex;

	[JsonIgnore]
	public static Cache Instance => CacheInstance;

	[JsonIgnore]
	private static Cache CacheInstance { get; set; }

	internal static void CreateInstance()
	{
		CacheInstance = new Cache();
		CacheInstance.LoadCache();
	}

	private Cache()
	{
		_bhMutex = new Mutex(initiallyOwned: false, "MUTEX:" + GetBase64MachineID());
	}

	internal bool GetResolvedAccount(UserDomainKey key, out ResolvedPrincipal value)
	{
		return _resolvedAccountNameDictionary.TryGetValue(key, out value);
	}

	internal bool GetResolvedDistinguishedName(string key, out ResolvedPrincipal value)
	{
		return _resolvedPrincipalDictionary.TryGetValue(key.ToUpper(), out value);
	}

	internal bool GetGlobalCatalogMatches(string key, out string[] sids)
	{
		return _globalCatalogDictionary.TryGetValue(key.ToUpper(), out sids);
	}

	internal bool GetSidType(string key, out LdapTypeEnum type)
	{
		return _sidTypeDictionary.TryGetValue(key.ToUpper(), out type);
	}

	internal void Add(UserDomainKey key, ResolvedPrincipal value)
	{
		_resolvedAccountNameDictionary.TryAdd(key, value);
	}

	internal void Add(string key, ResolvedPrincipal value)
	{
		_resolvedPrincipalDictionary.TryAdd(key.ToUpper(), value);
	}

	internal void Add(string key, string[] domains)
	{
		_globalCatalogDictionary.TryAdd(key.ToUpper(), domains);
	}

	internal void Add(string key, LdapTypeEnum type)
	{
		_sidTypeDictionary.TryAdd(key, type);
	}

	internal void LoadCache()
	{
		if (Options.Instance.InvalidateCache)
		{
			_globalCatalogDictionary = new ConcurrentDictionary<string, string[]>();
			_resolvedPrincipalDictionary = new ConcurrentDictionary<string, ResolvedPrincipal>();
			_sidTypeDictionary = new ConcurrentDictionary<string, LdapTypeEnum>();
			_resolvedAccountNameDictionary = new ConcurrentDictionary<UserDomainKey, ResolvedPrincipal>();
			Console.WriteLine("[-] Cache Invalidated: 0 Objects in Cache");
			Console.WriteLine();
			return;
		}
		string cacheFileName = GetCacheFileName();
		if (!File.Exists(cacheFileName))
		{
			_globalCatalogDictionary = new ConcurrentDictionary<string, string[]>();
			_resolvedPrincipalDictionary = new ConcurrentDictionary<string, ResolvedPrincipal>();
			_sidTypeDictionary = new ConcurrentDictionary<string, LdapTypeEnum>();
			_resolvedAccountNameDictionary = new ConcurrentDictionary<UserDomainKey, ResolvedPrincipal>();
			Console.WriteLine("[+] Cache File not Found: 0 Objects in cache");
			Console.WriteLine();
			return;
		}
		try
		{
			_bhMutex.WaitOne();
			byte[] bytes = File.ReadAllBytes(cacheFileName);
			string @string = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetString(bytes);
			CacheInstance = JsonConvert.DeserializeObject<Cache>(@string);
			Console.WriteLine($"[+] Cache File Found! Loaded {CacheInstance._resolvedPrincipalDictionary.Count + CacheInstance._globalCatalogDictionary.Count + CacheInstance._sidTypeDictionary.Count + CacheInstance._resolvedAccountNameDictionary.Count} Objects in cache");
			Console.WriteLine();
		}
		finally
		{
			_bhMutex.ReleaseMutex();
		}
	}

	private string GetCacheFileName()
	{
		string path = Options.Instance.CacheFilename ?? (GetBase64MachineID() + ".bin");
		return Path.Combine(Options.Instance.OutputDirectory, path);
	}

	internal void SaveCache()
	{
		if (Options.Instance.NoSaveCache)
		{
			return;
		}
		byte[] bytes = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetBytes(JsonConvert.SerializeObject(CacheInstance));
		string cacheFileName = GetCacheFileName();
		try
		{
			_bhMutex.WaitOne();
			using FileStream fileStream = new FileStream(cacheFileName, FileMode.Create, FileAccess.Write, FileShare.None);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		finally
		{
			_bhMutex.ReleaseMutex();
		}
	}

	private static string GetBase64MachineID()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", writable: false);
			if (registryKey2 == null)
			{
				return Helpers.Base64(Environment.MachineName) ?? "";
			}
			string input = registryKey2.GetValue("MachineGuid") as string;
			return Helpers.Base64(input);
		}
		catch
		{
			return Helpers.Base64(Environment.MachineName) ?? "";
		}
	}
}
