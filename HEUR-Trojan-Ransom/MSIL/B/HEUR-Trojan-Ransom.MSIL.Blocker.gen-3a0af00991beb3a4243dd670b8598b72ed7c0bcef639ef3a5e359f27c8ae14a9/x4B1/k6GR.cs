using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace x4B1;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class k6GR : ApplicationSettingsBase
{
	private static k6GR defaultInstance = (k6GR)(object)SettingsBase.Synchronized((SettingsBase)(object)new k6GR());

	public static k6GR Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=localhost\\SQLEXPRESS;Initial Catalog=bridgemanagement;Integrated Security=True")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string bridgemanagementConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("bridgemanagementConnectionString"));
}