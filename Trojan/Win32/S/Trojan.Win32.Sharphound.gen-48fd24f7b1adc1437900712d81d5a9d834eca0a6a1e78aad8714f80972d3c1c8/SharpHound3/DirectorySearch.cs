using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using SharpHound3.Enums;

namespace SharpHound3;

internal class DirectorySearch
{
	private readonly string _domainController;

	private readonly string _domainName;

	private readonly Domain _domain;

	private Dictionary<string, string> _domainGuidMap;

	private bool _isFaulted;

	private readonly string baseLdapPath;

	private readonly ConcurrentBag<LdapConnection> _connectionPool = new ConcurrentBag<LdapConnection>();

	public DirectorySearch(string domainName = null, string domainController = null)
	{
		_domain = GetDomain();
		_domainName = Helpers.NormalizeDomainName(domainName);
		baseLdapPath = "DC=" + _domainName.Replace(".", ",DC=");
		_domainController = Options.Instance.DomainController ?? domainController;
		_domainGuidMap = new Dictionary<string, string>();
		CreateSchemaMap();
	}

	internal async Task<string[]> LookupUserInGC(string username)
	{
		if (!Cache.Instance.GetGlobalCatalogMatches(username, out var sids2))
		{
			LdapConnection connection = GetGlobalCatalogConnection();
			try
			{
				SearchRequest searchRequest = CreateSearchRequest("(&(samAccountType=805306368)(samaccountname=" + username + "))", (SearchScope)2, new string[1] { "objectsid" });
				IAsyncResult iAsyncResult = connection.BeginSendRequest((DirectoryRequest)(object)searchRequest, (PartialResultProcessing)0, (AsyncCallback)null, (object)null);
				Task<SearchResponse> task = Task<SearchResponse>.Factory.FromAsync(iAsyncResult, (IAsyncResult x) => (SearchResponse)connection.EndSendRequest(x));
				try
				{
					SearchResponse response = await task;
					if (response == null)
					{
						sids2 = new string[0];
						Cache.Instance.Add(username, sids2);
						return sids2;
					}
					sids2 = Enumerable.ToArray(Enumerable.Where(Enumerable.Select(Enumerable.Cast<SearchResultEntry>((IEnumerable)response.get_Entries()), (SearchResultEntry entry) => entry.GetSid()), (string sid) => sid != null));
					Cache.Instance.Add(username, sids2);
					return sids2;
				}
				catch
				{
					return null;
				}
			}
			catch (LdapException)
			{
				return null;
			}
			finally
			{
				connection.Dispose();
			}
		}
		return sids2;
	}

	internal async Task<SearchResultEntry> GetOne(string ldapFilter, string[] props, SearchScope scope, string adsPath = null, bool globalCatalog = false)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		LdapConnection connection = (globalCatalog ? GetGlobalCatalogConnection() : GetLdapConnection());
		try
		{
			SearchRequest searchRequest = CreateSearchRequest(ldapFilter, scope, props, adsPath);
			IAsyncResult iAsyncResult = connection.BeginSendRequest((DirectoryRequest)(object)searchRequest, (PartialResultProcessing)0, (AsyncCallback)null, (object)null);
			Task<SearchResponse> task = Task<SearchResponse>.Factory.FromAsync(iAsyncResult, (IAsyncResult x) => (SearchResponse)connection.EndSendRequest(x));
			SearchResponse response = await task;
			if (((ReadOnlyCollectionBase)(object)response.get_Entries()).Count == 0)
			{
				return null;
			}
			return response.get_Entries().get_Item(0);
		}
		catch
		{
			return null;
		}
		finally
		{
			if (!globalCatalog)
			{
				_connectionPool.Add(connection);
			}
			else
			{
				connection.Dispose();
			}
		}
	}

	internal IEnumerable<SearchResultEntry> QueryLdap(string ldapFilter, string[] props, SearchScope scope, string adsPath = null, bool globalCatalog = false)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		LdapConnection connection = (globalCatalog ? GetGlobalCatalogConnection() : GetLdapConnection());
		try
		{
			SearchRequest searchRequest = CreateSearchRequest(ldapFilter, scope, props, adsPath);
			PageResultRequestControl pageRequest = new PageResultRequestControl(500);
			((DirectoryRequest)searchRequest).get_Controls().Add((DirectoryControl)(object)pageRequest);
			if (Options.Instance.ResolvedCollectionMethods.HasFlag(CollectionMethodResolved.ACL))
			{
				SecurityDescriptorFlagControl val = new SecurityDescriptorFlagControl();
				val.set_SecurityMasks((SecurityMasks)5);
				SecurityDescriptorFlagControl securityDescriptorFlagControl = val;
				((DirectoryRequest)searchRequest).get_Controls().Add((DirectoryControl)(object)securityDescriptorFlagControl);
			}
			while (true)
			{
				SearchResponse searchResponse;
				try
				{
					searchResponse = (SearchResponse)((DirectoryConnection)connection).SendRequest((DirectoryRequest)(object)searchRequest);
				}
				catch (Exception)
				{
					break;
				}
				if (((DirectoryResponse)searchResponse).get_Controls().Length == 1 && ((DirectoryResponse)searchResponse).get_Controls()[0] is PageResultResponseControl)
				{
					PageResultResponseControl pageResponse = (PageResultResponseControl)((DirectoryResponse)searchResponse).get_Controls()[0];
					foreach (SearchResultEntry item in (ReadOnlyCollectionBase)(object)searchResponse.get_Entries())
					{
						yield return item;
					}
					if (pageResponse.get_Cookie().Length != 0)
					{
						pageRequest.set_Cookie(pageResponse.get_Cookie());
						continue;
					}
					break;
				}
				Console.WriteLine("Server does not support paging");
				break;
			}
		}
		finally
		{
			if (!globalCatalog)
			{
				_connectionPool.Add(connection);
			}
			else
			{
				connection.Dispose();
			}
		}
	}

	internal async Task<List<string>> RangedRetrievalAsync(string distinguishedName, string attribute)
	{
		LdapConnection connection = GetLdapConnection();
		List<string> values = new List<string>();
		try
		{
			int index = 0;
			int step = 0;
			string baseString = attribute ?? "";
			string currentRange = $"{baseString};range={index}-*";
			bool searchDone = false;
			SearchRequest searchRequest = CreateSearchRequest(attribute + "=*", (SearchScope)0, new string[1] { currentRange }, distinguishedName);
			while (true)
			{
				IAsyncResult iASyncResult = connection.BeginSendRequest((DirectoryRequest)(object)searchRequest, (PartialResultProcessing)0, (AsyncCallback)null, (object)null);
				Task<SearchResponse> task = Task<SearchResponse>.Factory.FromAsync(iASyncResult, (IAsyncResult x) => (SearchResponse)connection.EndSendRequest(x));
				SearchResponse response = await task;
				if (response == null || ((ReadOnlyCollectionBase)(object)response.get_Entries()).Count != 1)
				{
					break;
				}
				SearchResultEntry entry = response.get_Entries().get_Item(0);
				foreach (string attr in entry.get_Attributes().get_AttributeNames())
				{
					currentRange = attr;
					searchDone = currentRange.IndexOf("*", 0, StringComparison.Ordinal) > 0;
					step = ((CollectionBase)(object)entry.get_Attributes().get_Item(currentRange)).Count;
				}
				object[] values2 = entry.get_Attributes().get_Item(currentRange).GetValues(typeof(string));
				for (int i = 0; i < values2.Length; i++)
				{
					string member = (string)values2[i];
					values.Add(member);
					index++;
				}
				if (!searchDone)
				{
					currentRange = $"{baseString};range={index}-{index + step}";
					searchRequest.get_Attributes().Clear();
					searchRequest.get_Attributes().Add(currentRange);
					continue;
				}
				return values;
			}
			return values;
		}
		finally
		{
			_connectionPool.Add(connection);
		}
	}

	internal bool GetAttributeFromGuid(string guid, out string name)
	{
		return _domainGuidMap.TryGetValue(guid, out name);
	}

	private Domain GetDomain()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			if (_domainName == null)
			{
				return Domain.GetCurrentDomain();
			}
			DirectoryContext val = new DirectoryContext((DirectoryContextType)0, _domainName);
			return Domain.GetDomain(val);
		}
		catch
		{
			_isFaulted = true;
			return null;
		}
	}

	private LdapConnection GetGlobalCatalogConnection()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		string text = _domainController ?? _domainName;
		LdapDirectoryIdentifier val = new LdapDirectoryIdentifier(text, 3268);
		LdapConnection val2 = ((Options.Instance.LdapUsername != null) ? new LdapConnection(val, new NetworkCredential(Options.Instance.LdapUsername, Options.Instance.LdapPassword)) : new LdapConnection(val));
		LdapSessionOptions sessionOptions = val2.get_SessionOptions();
		if (!Options.Instance.DisableKerberosSigning)
		{
			sessionOptions.set_Signing(true);
			sessionOptions.set_Sealing(true);
		}
		sessionOptions.set_ProtocolVersion(3);
		sessionOptions.set_ReferralChasing((ReferralChasingOptions)0);
		((DirectoryConnection)val2).set_Timeout(new TimeSpan(0, 5, 0));
		return val2;
	}

	private LdapConnection GetLdapConnection()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		if (_connectionPool.TryTake(out var result))
		{
			return result;
		}
		string text = _domainController ?? _domainName;
		int num = ((Options.Instance.LdapPort != 0) ? Options.Instance.LdapPort : (Options.Instance.SecureLDAP ? 636 : 389));
		LdapDirectoryIdentifier val = new LdapDirectoryIdentifier(text, num, false, false);
		result = ((Options.Instance.LdapUsername != null) ? new LdapConnection(val, new NetworkCredential(Options.Instance.LdapUsername, Options.Instance.LdapPassword)) : new LdapConnection(val));
		LdapSessionOptions sessionOptions = result.get_SessionOptions();
		if (!Options.Instance.DisableKerberosSigning)
		{
			sessionOptions.set_Signing(true);
			sessionOptions.set_Sealing(true);
		}
		sessionOptions.set_ProtocolVersion(3);
		sessionOptions.set_ReferralChasing((ReferralChasingOptions)0);
		sessionOptions.set_SendTimeout(new TimeSpan(0, 0, 10, 0));
		((DirectoryConnection)result).set_Timeout(new TimeSpan(0, 0, 10, 0));
		return result;
	}

	private SearchRequest CreateSearchRequest(string ldapFilter, SearchScope scope, string[] props, string adsPath = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string text = adsPath ?? baseLdapPath;
		SearchRequest val = new SearchRequest(text, ldapFilter, scope, props);
		((DirectoryRequest)val).get_Controls().Add((DirectoryControl)new SearchOptionsControl((SearchOption)1));
		return val;
	}

	private void CreateSchemaMap()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (_isFaulted)
		{
			return;
		}
		string name = ((ActiveDirectoryPartition)_domain.get_Forest().get_Schema()).get_Name();
		Console.WriteLine("[+] Creating Schema map for domain " + _domainName + " using path " + name);
		foreach (SearchResultEntry item in QueryLdap("(schemaIDGUID=*)", new string[2] { "schemaidguid", "name" }, (SearchScope)2, name))
		{
			string property = item.GetProperty("name");
			string key = new Guid(item.GetPropertyAsBytes("schemaidguid")).ToString();
			try
			{
				dictionary.Add(key, property);
			}
			catch
			{
			}
		}
		_domainGuidMap = dictionary;
	}

	~DirectorySearch()
	{
		foreach (LdapConnection item in _connectionPool)
		{
			item.Dispose();
		}
	}
}
