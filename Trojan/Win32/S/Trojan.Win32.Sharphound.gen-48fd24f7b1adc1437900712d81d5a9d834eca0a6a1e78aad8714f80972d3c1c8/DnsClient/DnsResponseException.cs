using System;

namespace DnsClient;

public class DnsResponseException : Exception
{
	public DnsResponseCode Code { get; }

	public string AuditTrail { get; internal set; }

	public string DnsError { get; }

	public DnsResponseException()
		: base("Unknown Error")
	{
		Code = DnsResponseCode.Unassigned;
		DnsError = DnsResponseCodeText.GetErrorText(Code);
	}

	public DnsResponseException(string message)
		: base(message)
	{
		Code = DnsResponseCode.Unassigned;
		DnsError = DnsResponseCodeText.GetErrorText(Code);
	}

	public DnsResponseException(DnsResponseCode code)
		: base(DnsResponseCodeText.GetErrorText(code))
	{
		Code = code;
		DnsError = DnsResponseCodeText.GetErrorText(Code);
	}

	public DnsResponseException(string message, Exception innerException)
		: base(message, innerException)
	{
		Code = DnsResponseCode.Unassigned;
		DnsError = DnsResponseCodeText.GetErrorText(Code);
	}

	public DnsResponseException(DnsResponseCode code, string message)
		: base(message)
	{
		Code = code;
		DnsError = DnsResponseCodeText.GetErrorText(Code);
	}

	public DnsResponseException(DnsResponseCode code, string message, Exception innerException)
		: base(message, innerException)
	{
		Code = code;
		DnsError = DnsResponseCodeText.GetErrorText(Code);
	}
}
