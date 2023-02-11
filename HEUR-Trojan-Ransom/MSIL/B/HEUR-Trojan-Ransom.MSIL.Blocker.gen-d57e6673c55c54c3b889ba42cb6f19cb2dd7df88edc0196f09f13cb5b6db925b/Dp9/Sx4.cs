using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Dp9;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[CompilerGenerated]
internal sealed class Sx4 : ApplicationSettingsBase
{
	private static Sx4 defaultInstance = (Sx4)(object)SettingsBase.Synchronized((SettingsBase)(object)new Sx4());

	public static Sx4 Default => defaultInstance;

	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\hms_Database.accdb")]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DebuggerNonUserCode]
	public string hms_DatabaseConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("hms_DatabaseConnectionString"));
}
