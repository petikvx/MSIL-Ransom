using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Gkdlku.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings m_a;

	public Settings()
	{
		_ = 7;
		if (false)
		{
		}
		((ApplicationSettingsBase)this)._002Ector();
	}

	static Settings()
	{
		Settings obj = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
		if (8u != 0)
		{
			Settings.m_a = obj;
		}
	}

	public static Settings a()
	{
		return Settings.m_a;
	}
}
