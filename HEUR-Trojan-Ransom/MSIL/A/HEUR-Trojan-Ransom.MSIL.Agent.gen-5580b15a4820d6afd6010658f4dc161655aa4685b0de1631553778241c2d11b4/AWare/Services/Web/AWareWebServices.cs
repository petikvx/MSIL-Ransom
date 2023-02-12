using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AWare.Models.Web;
using Newtonsoft.Json;

namespace AWare.Services.Web
{
	// Token: 0x02000005 RID: 5
	public class AWareWebServices
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000248E File Offset: 0x0000068E
		private string Uid { get; }

		// Token: 0x0600000C RID: 12 RVA: 0x00002496 File Offset: 0x00000696
		public AWareWebServices(string uid)
		{
			this.Uid = uid;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024A8 File Offset: 0x000006A8
		public async Task<AWareWebResponse> InitializeAWareWebServicesAsync()
		{
			bool flag = string.IsNullOrEmpty(this.Uid) || string.IsNullOrEmpty("https://example.com/server/index.php");
			if (flag)
			{
				throw new ApplicationException("An unexpected error has occurred!");
			}
			HttpClientHandler httpClientHandler = new HttpClientHandler();
			httpClientHandler.ServerCertificateCustomValidationCallback = (HttpRequestMessage sender, X509Certificate2 cert, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
			this._httpClient = new HttpClient(httpClientHandler)
			{
				BaseAddress = new Uri("https://example.com/server/index.php")
			};
			HttpRequestMessage requestSettings = new HttpRequestMessage(HttpMethod.Post, "")
			{
				Content = new FormUrlEncodedContent(new Dictionary<string, string>
				{
					{ "U-ID", this.Uid },
					{
						"PC-Name",
						Environment.MachineName
					}
				})
			};
			HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(requestSettings);
			HttpResponseMessage aWareResponse = httpResponseMessage;
			httpResponseMessage = null;
			if (!aWareResponse.IsSuccessStatusCode)
			{
				throw new HttpRequestException("An error occurred in the request");
			}
			string text = await aWareResponse.Content.ReadAsStringAsync();
			string aWareResponseString = text;
			text = null;
			return JsonConvert.DeserializeObject<AWareWebResponse>(aWareResponseString);
		}

		// Token: 0x04000009 RID: 9
		private HttpClient _httpClient;
	}
}
