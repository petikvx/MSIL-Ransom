using System.Resources;
using FxResources.System.Threading.Tasks.Dataflow;

namespace System;

internal static class SR1
{
	private static ResourceManager s_resourceManager;

	internal static ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new ResourceManager(typeof(FxResources.System.Threading.Tasks.Dataflow.SR)));

	internal static string ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity => GetResourceString("ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity");

	internal static string ArgumentOutOfRange_GenericPositive => GetResourceString("ArgumentOutOfRange_GenericPositive");

	internal static string ArgumentOutOfRange_NeedNonNegOrNegative1 => GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1");

	internal static string Argument_BoundedCapacityNotSupported => GetResourceString("Argument_BoundedCapacityNotSupported");

	internal static string Argument_CantConsumeFromANullSource => GetResourceString("Argument_CantConsumeFromANullSource");

	internal static string Argument_InvalidMessageHeader => GetResourceString("Argument_InvalidMessageHeader");

	internal static string Argument_InvalidMessageId => GetResourceString("Argument_InvalidMessageId");

	internal static string Argument_NonGreedyNotSupported => GetResourceString("Argument_NonGreedyNotSupported");

	internal static string InvalidOperation_DataNotAvailableForReceive => GetResourceString("InvalidOperation_DataNotAvailableForReceive");

	internal static string InvalidOperation_FailedToConsumeReservedMessage => GetResourceString("InvalidOperation_FailedToConsumeReservedMessage");

	internal static string InvalidOperation_MessageNotReservedByTarget => GetResourceString("InvalidOperation_MessageNotReservedByTarget");

	internal static string NotSupported_MemberNotNeeded => GetResourceString("NotSupported_MemberNotNeeded");

	internal static string ConcurrentCollection_SyncRoot_NotSupported => GetResourceString("ConcurrentCollection_SyncRoot_NotSupported");

	internal static string InvalidOperation_ErrorDuringCleanup => GetResourceString("InvalidOperation_ErrorDuringCleanup");

	private static bool UsingResourceKeys()
	{
		return false;
	}

	internal static string GetResourceString(string resourceKey, string defaultString = null)
	{
		if (UsingResourceKeys())
		{
			return defaultString ?? resourceKey;
		}
		string text = null;
		try
		{
			text = ResourceManager.GetString(resourceKey);
		}
		catch (MissingManifestResourceException)
		{
		}
		if (defaultString != null && resourceKey.Equals(text))
		{
			return defaultString;
		}
		return text;
	}

	internal static string Format(string resourceFormat, object p1)
	{
		if (UsingResourceKeys())
		{
			return string.Join(", ", resourceFormat, p1);
		}
		return string.Format(resourceFormat, new object[1] { p1 });
	}

	internal static string Format(string resourceFormat, object p1, object p2)
	{
		if (UsingResourceKeys())
		{
			return string.Join(", ", resourceFormat, p1, p2);
		}
		return string.Format(resourceFormat, new object[2] { p1, p2 });
	}

	internal static string Format(string resourceFormat, object p1, object p2, object p3)
	{
		if (UsingResourceKeys())
		{
			return string.Join(", ", resourceFormat, p1, p2, p3);
		}
		return string.Format(resourceFormat, new object[3] { p1, p2, p3 });
	}

	internal static string Format(string resourceFormat, params object[] args)
	{
		if (args != null)
		{
			if (UsingResourceKeys())
			{
				return resourceFormat + ", " + string.Join(", ", args);
			}
			return string.Format(resourceFormat, args);
		}
		return resourceFormat;
	}

	internal static string Format(IFormatProvider provider, string resourceFormat, object p1)
	{
		if (UsingResourceKeys())
		{
			return string.Join(", ", resourceFormat, p1);
		}
		return string.Format(provider, resourceFormat, new object[1] { p1 });
	}

	internal static string Format(IFormatProvider provider, string resourceFormat, object p1, object p2)
	{
		if (UsingResourceKeys())
		{
			return string.Join(", ", resourceFormat, p1, p2);
		}
		return string.Format(provider, resourceFormat, new object[2] { p1, p2 });
	}

	internal static string Format(IFormatProvider provider, string resourceFormat, object p1, object p2, object p3)
	{
		if (UsingResourceKeys())
		{
			return string.Join(", ", resourceFormat, p1, p2, p3);
		}
		return string.Format(provider, resourceFormat, new object[3] { p1, p2, p3 });
	}

	internal static string Format(IFormatProvider provider, string resourceFormat, params object[] args)
	{
		if (args != null)
		{
			if (UsingResourceKeys())
			{
				return resourceFormat + ", " + string.Join(", ", args);
			}
			return string.Format(provider, resourceFormat, args);
		}
		return resourceFormat;
	}
}
