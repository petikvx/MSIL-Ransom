using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Main.Tools;

internal static class Blockr
{
	private static string BlockrAddress => "http://btc.blockr.io/api/v1/";

	internal static double GetPrice()
	{
		string string_ = Blockr.smethod_0(BlockrAddress, "coin/info/");
		JObject val = Blockr.smethod_3(Blockr.smethod_2(Blockr.smethod_1(), string_));
		JToken val2 = Blockr.smethod_4(val, "status");
		if (val2 != null && Blockr.smethod_6(Blockr.smethod_5((object)val2), "error"))
		{
			throw Blockr.smethod_7(Blockr.smethod_5((object)val));
		}
		return Blockr.smethod_8(Blockr.smethod_8(Blockr.smethod_4(val, "data"), (object)"markets"), (object)"coinbase").Value<double>((object)"value");
	}

	internal static double GetBalanceBtc(string address)
	{
		string string_ = Blockr.smethod_9(BlockrAddress, "address/balance/", address);
		JObject val = Blockr.smethod_3(Blockr.smethod_2(Blockr.smethod_1(), string_));
		JToken val2 = Blockr.smethod_4(val, "status");
		if (val2 != null && Blockr.smethod_6(Blockr.smethod_5((object)val2), "error"))
		{
			throw Blockr.smethod_7(Blockr.smethod_5((object)val));
		}
		return Blockr.smethod_4(val, "data").Value<double>((object)"balance");
	}

	static string smethod_0(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static WebClient smethod_1()
	{
		return new WebClient();
	}

	static string smethod_2(WebClient webClient_0, string string_0)
	{
		return webClient_0.DownloadString(string_0);
	}

	static JObject smethod_3(string string_0)
	{
		return JObject.Parse(string_0);
	}

	static JToken smethod_4(JObject jobject_0, string string_0)
	{
		return jobject_0.get_Item(string_0);
	}

	static string smethod_5(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_6(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static Exception smethod_7(string string_0)
	{
		return new Exception(string_0);
	}

	static JToken smethod_8(JToken jtoken_0, object object_0)
	{
		return jtoken_0.get_Item(object_0);
	}

	static string smethod_9(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}
}
