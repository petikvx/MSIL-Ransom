using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace p3X;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class c5F : ApplicationSettingsBase
{
	private static c5F defaultInstance = (c5F)(object)SettingsBase.Synchronized((SettingsBase)(object)new c5F());

	public static c5F Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=localhost\\SQLEXPRESS;Initial Catalog=bridgemanagement;Integrated Security=True")]
	public string bridgemanagementConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("bridgemanagementConnectionString"));
}
