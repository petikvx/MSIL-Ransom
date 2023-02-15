using System;

namespace SmartAssembly.Zip;

public enum CompressionAlgorithm
{
	[Obsolete("Use `RawZip`.")]
	PKZip,
	RawZip,
	[Obsolete("Use `RawZipAndAes`.")]
	RawZipAndDes,
	RawZipAndAes
}
