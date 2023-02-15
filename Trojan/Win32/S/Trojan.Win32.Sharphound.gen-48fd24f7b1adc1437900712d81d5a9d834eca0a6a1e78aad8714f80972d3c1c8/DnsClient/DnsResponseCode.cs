namespace DnsClient;

public enum DnsResponseCode : short
{
	NoError = 0,
	FormatError = 1,
	ServerFailure = 2,
	NotExistentDomain = 3,
	NotImplemented = 4,
	Refused = 5,
	ExistingDomain = 6,
	ExistingResourceRecordSet = 7,
	MissingResourceRecordSet = 8,
	NotAuthorized = 9,
	NotZone = 10,
	BadVersionOrBadSignature = 16,
	BadKey = 17,
	BadTime = 18,
	BadMode = 19,
	BadName = 20,
	BadAlgorithm = 21,
	BadTruncation = 22,
	BadCookie = 23,
	Unassigned = 666,
	ConnectionTimeout = 999
}
