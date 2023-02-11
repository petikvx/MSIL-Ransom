using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Jn4w;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Md0o : ApplicationSettingsBase
{
	private static Md0o defaultInstance = (Md0o)(object)SettingsBase.Synchronized((SettingsBase)(object)new Md0o());

	public static Md0o Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=localhost\\SQLEXPRESS;Initial Catalog=bridgemanagement;Integrated Security=True")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	public string bridgemanagementConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("bridgemanagementConnectionString"));
}
