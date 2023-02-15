namespace DnsClient.Protocol;

public class SshfpRecord : DnsResourceRecord
{
	public SshfpAlgorithm Algorithm { get; }

	public SshfpFingerprintType FingerprintType { get; }

	public string Fingerprint { get; }

	public SshfpRecord(ResourceRecordInfo info, SshfpAlgorithm algorithm, SshfpFingerprintType fingerprintType, string fingerprint)
		: base(info)
	{
		Algorithm = algorithm;
		FingerprintType = fingerprintType;
		Fingerprint = fingerprint;
	}

	private protected override string RecordToString()
	{
		return $"{(int)Algorithm} {(int)FingerprintType} {Fingerprint}";
	}
}
