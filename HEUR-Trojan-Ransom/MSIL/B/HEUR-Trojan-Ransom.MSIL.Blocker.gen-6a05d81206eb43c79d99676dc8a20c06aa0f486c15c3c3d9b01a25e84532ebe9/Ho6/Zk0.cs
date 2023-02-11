using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace Ho6;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Zk0 : ApplicationSettingsBase
{
	private static Zk0 defaultInstance = (Zk0)(object)SettingsBase.Synchronized((SettingsBase)(object)new Zk0());

	public static Zk0 Default => defaultInstance;

	[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True")]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string apartConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("apartConnectionString"));
}
