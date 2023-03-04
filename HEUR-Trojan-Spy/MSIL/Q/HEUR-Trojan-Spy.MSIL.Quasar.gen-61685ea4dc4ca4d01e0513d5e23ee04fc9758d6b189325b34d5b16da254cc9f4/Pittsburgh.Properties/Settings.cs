using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pittsburgh.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("Rules")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string RulesDirectory => (string)((SettingsBase)this).get_Item("RulesDirectory");

	[DefaultSettingValue("20")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int LinesBefore
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("LinesBefore");
		}
		set
		{
			((SettingsBase)this).set_Item("LinesBefore", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("40")]
	[DebuggerNonUserCode]
	public int LinesAfter
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("LinesAfter");
		}
		set
		{
			((SettingsBase)this).set_Item("LinesAfter", (object)value);
		}
	}
}
