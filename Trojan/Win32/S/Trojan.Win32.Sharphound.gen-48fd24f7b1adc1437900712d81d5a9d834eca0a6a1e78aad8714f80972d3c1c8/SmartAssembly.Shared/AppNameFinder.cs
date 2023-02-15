using System;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	private static Version version_0 = new Version("8.0.3.4821");

	private static string string_0 = null;

	public static Version Version => version_0;

	public static string AppName => AppNameMinusVersion + " " + MajorVersion;

	public static string TitleVersion => string_0 ?? (string_0 = $"{version_0.Major}.{version_0.Minor}");

	public static int MajorVersion => version_0.Major;

	public static string AppNameMinusVersion => "SmartAssembly";

	private AppNameFinder()
	{
	}
}
