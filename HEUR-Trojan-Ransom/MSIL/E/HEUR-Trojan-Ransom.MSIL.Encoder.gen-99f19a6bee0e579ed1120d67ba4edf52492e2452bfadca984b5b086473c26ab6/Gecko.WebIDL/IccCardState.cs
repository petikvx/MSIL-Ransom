using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IccCardState
{
	[Description("unknown")]
	unknown,
	[Description("ready")]
	ready,
	[Description("pinRequired")]
	pinRequired,
	[Description("pukRequired")]
	pukRequired,
	[Description("permanentBlocked")]
	permanentBlocked,
	[Description("personalizationInProgress")]
	personalizationInProgress,
	[Description("personalizationReady")]
	personalizationReady,
	[Description("networkLocked")]
	networkLocked,
	[Description("networkSubsetLocked")]
	networkSubsetLocked,
	[Description("corporateLocked")]
	corporateLocked,
	[Description("serviceProviderLocked")]
	serviceProviderLocked,
	[Description("simPersonalizationLocked")]
	simPersonalizationLocked,
	[Description("networkPukRequired")]
	networkPukRequired,
	[Description("networkSubsetPukRequired")]
	networkSubsetPukRequired,
	[Description("corporatePukRequired")]
	corporatePukRequired,
	[Description("serviceProviderPukRequired")]
	serviceProviderPukRequired,
	[Description("simPersonalizationPukRequired")]
	simPersonalizationPukRequired,
	[Description("network1Locked")]
	network1Locked,
	[Description("network2Locked")]
	network2Locked,
	[Description("hrpdNetworkLocked")]
	hrpdNetworkLocked,
	[Description("ruimCorporateLocked")]
	ruimCorporateLocked,
	[Description("ruimServiceProviderLocked")]
	ruimServiceProviderLocked,
	[Description("ruimPersonalizationLocked")]
	ruimPersonalizationLocked,
	[Description("network1PukRequired")]
	network1PukRequired,
	[Description("network2PukRequired")]
	network2PukRequired,
	[Description("hrpdNetworkPukRequired")]
	hrpdNetworkPukRequired,
	[Description("ruimCorporatePukRequired")]
	ruimCorporatePukRequired,
	[Description("ruimServiceProviderPukRequired")]
	ruimServiceProviderPukRequired,
	[Description("ruimPersonalizationPukRequired")]
	ruimPersonalizationPukRequired,
	[Description("illegal")]
	illegal
}
