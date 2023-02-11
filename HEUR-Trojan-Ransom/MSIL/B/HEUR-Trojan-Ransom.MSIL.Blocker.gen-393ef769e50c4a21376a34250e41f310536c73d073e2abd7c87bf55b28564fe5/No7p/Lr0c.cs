using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace No7p;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Lr0c : ApplicationSettingsBase
{
	private static Lr0c defaultInstance = (Lr0c)(object)SettingsBase.Synchronized((SettingsBase)(object)new Lr0c());

	public static Lr0c Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=localhost\\SQLEXPRESS;Initial Catalog=bridgemanagement;Integrated Security=True")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string bridgemanagementConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("bridgemanagementConnectionString"));
}
