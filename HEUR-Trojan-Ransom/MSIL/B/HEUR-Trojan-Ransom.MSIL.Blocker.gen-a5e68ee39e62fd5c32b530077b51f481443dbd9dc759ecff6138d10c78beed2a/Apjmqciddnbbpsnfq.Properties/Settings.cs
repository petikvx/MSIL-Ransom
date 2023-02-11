using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Apjmqciddnbbpsnfq.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	internal static Settings AwakeSingleton;

	public static Settings Default => defaultInstance;

	internal static bool RegisterSingleton()
	{
		return AwakeSingleton == null;
	}

	internal static Settings InsertSingleton()
	{
		return AwakeSingleton;
	}
}
