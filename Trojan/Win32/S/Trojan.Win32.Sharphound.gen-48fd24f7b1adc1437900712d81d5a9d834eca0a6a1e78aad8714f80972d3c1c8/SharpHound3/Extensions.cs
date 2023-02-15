using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Security.Principal;
using SharpHound3.Enums;

namespace SharpHound3;

internal static class Extensions
{
	public static void PrintEntry(this SearchResultEntry searchResultEntry)
	{
		foreach (object attributeName in searchResultEntry.get_Attributes().get_AttributeNames())
		{
			string text = attributeName.ToString();
			Console.WriteLine(text);
			Console.WriteLine(searchResultEntry.GetProperty(text));
		}
	}

	public static string GetProperty(this SearchResultEntry searchResultEntry, string property)
	{
		if (!searchResultEntry.get_Attributes().Contains(property))
		{
			return null;
		}
		DirectoryAttribute val = searchResultEntry.get_Attributes().get_Item(property);
		object[] values = val.GetValues(typeof(string));
		if (values.Length == 0)
		{
			return null;
		}
		if (!(values[0] is string text) || text.Length == 0)
		{
			return null;
		}
		return text;
	}

	public static string GetSid(this SearchResultEntry searchResultEntry)
	{
		try
		{
			if (!searchResultEntry.get_Attributes().Contains("objectsid"))
			{
				return null;
			}
		}
		catch (ArgumentNullException)
		{
			return null;
		}
		object[] values;
		try
		{
			values = searchResultEntry.get_Attributes().get_Item("objectsid").GetValues(typeof(byte[]));
		}
		catch (NotSupportedException)
		{
			return null;
		}
		if (values.Length == 0)
		{
			return null;
		}
		if (!(values[0] is byte[] array) || array.Length == 0)
		{
			return null;
		}
		try
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(array, 0);
			return securityIdentifier.Value.ToUpper();
		}
		catch (ArgumentNullException)
		{
			return null;
		}
	}

	public static string[] GetPropertyAsArray(this SearchResultEntry searchResultEntry, string property)
	{
		if (!searchResultEntry.get_Attributes().Contains(property))
		{
			return new string[0];
		}
		DirectoryAttribute val = searchResultEntry.get_Attributes().get_Item(property);
		object[] values = val.GetValues(typeof(string));
		if (!(values is string[] result))
		{
			return null;
		}
		return result;
	}

	public static byte[][] GetPropertyAsArrayOfBytes(this SearchResultEntry searchResultEntry, string property)
	{
		List<byte[]> list = new List<byte[]>();
		if (!searchResultEntry.get_Attributes().Contains(property))
		{
			return list.ToArray();
		}
		DirectoryAttribute val = searchResultEntry.get_Attributes().get_Item(property);
		object[] values = val.GetValues(typeof(byte[]));
		if (!(values is byte[][] result))
		{
			return null;
		}
		return result;
	}

	public static byte[] GetPropertyAsBytes(this SearchResultEntry searchResultEntry, string property)
	{
		if (!searchResultEntry.get_Attributes().Contains(property))
		{
			return null;
		}
		DirectoryAttribute val = searchResultEntry.get_Attributes().get_Item(property);
		object[] values = val.GetValues(typeof(byte[]));
		if (values.Length == 0)
		{
			return null;
		}
		if (!(values[0] is byte[] array) || array.Length == 0)
		{
			return null;
		}
		return array;
	}

	public static string GetObjectIdentifier(this SearchResultEntry searchResultEntry)
	{
		if (!searchResultEntry.get_Attributes().Contains("objectsid") && !searchResultEntry.get_Attributes().Contains("objectguid"))
		{
			return null;
		}
		if (searchResultEntry.get_Attributes().Contains("objectsid"))
		{
			return searchResultEntry.GetSid();
		}
		if (searchResultEntry.get_Attributes().Contains("objectguid"))
		{
			byte[] propertyAsBytes = searchResultEntry.GetPropertyAsBytes("objectguid");
			return new Guid(propertyAsBytes).ToString().ToUpper();
		}
		return null;
	}

	public static LdapTypeEnum GetLdapType(this SearchResultEntry searchResultEntry)
	{
		string objectIdentifier = searchResultEntry.GetObjectIdentifier();
		if (objectIdentifier == null)
		{
			return LdapTypeEnum.Unknown;
		}
		if (searchResultEntry.GetPropertyAsBytes("msds-groupmsamembership") != null)
		{
			return LdapTypeEnum.User;
		}
		if (CommonPrincipal.GetCommonSid(objectIdentifier, out var commonPrincipal))
		{
			return commonPrincipal.Type;
		}
		LdapTypeEnum result = LdapTypeEnum.Unknown;
		string property = searchResultEntry.GetProperty("samaccounttype");
		if (property != null)
		{
			if (property == "805306370")
			{
				return LdapTypeEnum.Unknown;
			}
			result = Helpers.SamAccountTypeToType(property);
		}
		else
		{
			string[] propertyAsArray = searchResultEntry.GetPropertyAsArray("objectClass");
			if (propertyAsArray == null)
			{
				result = LdapTypeEnum.Unknown;
			}
			else if (Enumerable.Contains(propertyAsArray, "groupPolicyContainer"))
			{
				result = LdapTypeEnum.GPO;
			}
			else if (Enumerable.Contains(propertyAsArray, "organizationalUnit"))
			{
				result = LdapTypeEnum.OU;
			}
			else if (Enumerable.Contains(propertyAsArray, "domain"))
			{
				result = LdapTypeEnum.Domain;
			}
		}
		if (searchResultEntry.GetPropertyAsBytes("msds-groupmsamembership") != null)
		{
			result = LdapTypeEnum.User;
		}
		return result;
	}
}
