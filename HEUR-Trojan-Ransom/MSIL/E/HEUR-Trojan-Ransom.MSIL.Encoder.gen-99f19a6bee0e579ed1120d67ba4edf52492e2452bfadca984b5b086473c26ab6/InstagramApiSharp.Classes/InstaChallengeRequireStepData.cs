using Newtonsoft.Json;

namespace InstagramApiSharp.Classes;

public class InstaChallengeRequireStepData
{
	[JsonProperty("choice")]
	public string Choice { get; set; }

	[JsonProperty("fb_access_token")]
	public string FbAccessToken { get; set; }

	[JsonProperty("big_blue_token")]
	public string BigBlueToken { get; set; }

	[JsonProperty("google_oauth_token")]
	public string GoogleOauthToken { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }

	[JsonProperty("phone_number")]
	public string PhoneNumber { get; set; }

	public bool SubmitPhoneRequired => PhoneNumber.ToLower().Contains("none");
}
