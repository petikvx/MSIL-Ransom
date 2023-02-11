using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Cf2;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class d1Y : ApplicationSettingsBase
{
	private static d1Y defaultInstance = (d1Y)(object)SettingsBase.Synchronized((SettingsBase)(object)new d1Y());

	public static d1Y Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True")]
	public string apartConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("apartConnectionString"));
}
