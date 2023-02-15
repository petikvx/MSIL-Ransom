using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpHound3;

internal class AccountCacheConverter : JsonConverter
{
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		IDictionary<UserDomainKey, ResolvedPrincipal> dictionary = (IDictionary<UserDomainKey, ResolvedPrincipal>)value;
		JObject jObject = new JObject();
		foreach (KeyValuePair<UserDomainKey, ResolvedPrincipal> item in dictionary)
		{
			try
			{
				jObject.Add(item.Key.ToString(), JToken.FromObject(item.Value));
			}
			catch
			{
			}
		}
		jObject.WriteTo(writer);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JObject jObject = JObject.Load(reader);
		IDictionary<UserDomainKey, ResolvedPrincipal> dictionary = ((IDictionary<UserDomainKey, ResolvedPrincipal>)existingValue) ?? new ConcurrentDictionary<UserDomainKey, ResolvedPrincipal>();
		foreach (JProperty item in jObject.Properties())
		{
			UserDomainKey userDomainKey = new UserDomainKey();
			string[] array = item.Name.Split(new char[1] { '\\' });
			userDomainKey.AccountDomain = array[0];
			userDomainKey.AccountName = array[1];
			try
			{
				dictionary.Add(userDomainKey, item.Value.ToObject<ResolvedPrincipal>());
			}
			catch
			{
			}
		}
		return dictionary;
	}

	public override bool CanConvert(Type objectType)
	{
		return typeof(IDictionary<UserDomainKey, string>).IsAssignableFrom(objectType);
	}
}
