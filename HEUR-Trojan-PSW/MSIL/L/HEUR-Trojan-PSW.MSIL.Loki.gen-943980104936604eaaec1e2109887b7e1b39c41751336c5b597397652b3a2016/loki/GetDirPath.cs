using System;
using System.IO;

namespace loki;

public class GetDirPath
{
	public static readonly string DefaultPath = Environment.GetEnvironmentVariable("Temp");

	public static readonly string User_Name = Path.Combine(DefaultPath, Environment.UserName);
}
