using System;

namespace rmtadrm;

public class wrmstimzMYINF
{
	public string wrmstimzuip = "";

	public string wrmstimzclientNum = "";

	public string wrmstimzuname = "";

	public string wrmstimzapver;

	public string wrmstimzcname = "";

	public string wrmstimzlancard = "";

	private void wrmstimzInfo()
	{
		wrmstimzapver = "S.P.0.1|wrmstimz".Split(new char[1] { '|' })[0];
		wrmstimzcname = Environment.MachineName;
		wrmstimzuname = Environment.UserName;
		wrmstimzuip = "";
		wrmstimzlancard = "";
	}

	public wrmstimzMYINF()
	{
		wrmstimzInfo();
	}
}
