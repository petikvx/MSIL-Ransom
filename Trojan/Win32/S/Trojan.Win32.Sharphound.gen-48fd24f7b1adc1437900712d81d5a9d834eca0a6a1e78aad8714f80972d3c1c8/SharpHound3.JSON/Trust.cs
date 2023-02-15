using Newtonsoft.Json;

namespace SharpHound3.JSON;

public class Trust
{
	[JsonProperty]
	internal string TargetDomainSid { get; set; }

	[JsonProperty]
	internal bool IsTransitive { get; set; }

	[JsonProperty]
	internal TrustDirection TrustDirection { get; set; }

	[JsonProperty]
	internal TrustType TrustType { get; set; }

	[JsonProperty]
	internal bool SidFilteringEnabled { get; set; }

	[JsonProperty]
	internal string TargetDomainName { get; set; }
}
