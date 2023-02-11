using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Ww20;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Lk4e : ApplicationSettingsBase
{
	private static Lk4e defaultInstance = (Lk4e)(object)SettingsBase.Synchronized((SettingsBase)(object)new Lk4e());

	public static Lk4e Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=localhost\\SQLEXPRESS;Initial Catalog=bridgemanagement;Integrated Security=True")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string bridgemanagementConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("bridgemanagementConnectionString"));
}
