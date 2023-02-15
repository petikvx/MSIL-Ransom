using System.Collections.Generic;

namespace DnsClient;

internal static class DnsResponseCodeText
{
	internal const string BADALG = "Algorithm not supported";

	internal const string BADCOOKIE = "Bad/missing Server Cookie";

	internal const string BADKEY = "Key not recognized";

	internal const string BADMODE = "Bad TKEY Mode";

	internal const string BADNAME = "Duplicate key name";

	internal const string BADSIG = "TSIG Signature Failure";

	internal const string BADTIME = "Signature out of time window";

	internal const string BADTRUNC = "Bad Truncation";

	internal const string BADVERS = "Bad OPT Version";

	internal const string FormErr = "Format Error";

	internal const string NoError = "No Error";

	internal const string NotAuth = "Server Not Authoritative for zone or Not Authorized";

	internal const string NotImp = "Not Implemented";

	internal const string NotZone = "Name not contained in zone";

	internal const string NXDomain = "Non-Existent Domain";

	internal const string NXRRSet = "RR Set that should exist does not";

	internal const string Refused = "Query Refused";

	internal const string ServFail = "Server Failure";

	internal const string Unassigned = "Unknown Error";

	internal const string YXDomain = "Name Exists when it should not";

	internal const string YXRRSet = "RR Set Exists when it should not";

	private static readonly Dictionary<DnsResponseCode, string> errors = new Dictionary<DnsResponseCode, string>
	{
		{
			DnsResponseCode.NoError,
			"No Error"
		},
		{
			DnsResponseCode.FormatError,
			"Format Error"
		},
		{
			DnsResponseCode.ServerFailure,
			"Server Failure"
		},
		{
			DnsResponseCode.NotExistentDomain,
			"Non-Existent Domain"
		},
		{
			DnsResponseCode.NotImplemented,
			"Not Implemented"
		},
		{
			DnsResponseCode.Refused,
			"Query Refused"
		},
		{
			DnsResponseCode.ExistingDomain,
			"Name Exists when it should not"
		},
		{
			DnsResponseCode.ExistingResourceRecordSet,
			"RR Set Exists when it should not"
		},
		{
			DnsResponseCode.MissingResourceRecordSet,
			"RR Set that should exist does not"
		},
		{
			DnsResponseCode.NotAuthorized,
			"Server Not Authoritative for zone or Not Authorized"
		},
		{
			DnsResponseCode.NotZone,
			"Name not contained in zone"
		},
		{
			DnsResponseCode.BadVersionOrBadSignature,
			"Bad OPT Version"
		},
		{
			DnsResponseCode.BadKey,
			"Key not recognized"
		},
		{
			DnsResponseCode.BadTime,
			"Signature out of time window"
		},
		{
			DnsResponseCode.BadMode,
			"Bad TKEY Mode"
		},
		{
			DnsResponseCode.BadName,
			"Duplicate key name"
		},
		{
			DnsResponseCode.BadAlgorithm,
			"Algorithm not supported"
		},
		{
			DnsResponseCode.BadTruncation,
			"Bad Truncation"
		},
		{
			DnsResponseCode.BadCookie,
			"Bad/missing Server Cookie"
		}
	};

	public static string GetErrorText(DnsResponseCode code)
	{
		if (!errors.ContainsKey(code))
		{
			return "Unknown Error";
		}
		return errors[code];
	}
}
