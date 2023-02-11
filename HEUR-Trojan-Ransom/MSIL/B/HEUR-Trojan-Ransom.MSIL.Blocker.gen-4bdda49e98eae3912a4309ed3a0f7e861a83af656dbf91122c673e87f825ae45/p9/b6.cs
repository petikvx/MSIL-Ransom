using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using s4;

namespace p9;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class b6 : ApplicationSettingsBase
{
	private static b6 T = (b6)(object)SettingsBase.Synchronized((SettingsBase)(object)new b6());

	public static b6 Default
	{
		get
		{
			//Discarded unreachable code: IL_0002, IL_001c
			ApplicationSettingsBase t = (ApplicationSettingsBase)(object)T;
			b6 result = t as b6;
			g5.I[142] = (byte)((g5.I[142] | g5.I[170]) & 0x46);
			return result;
		}
	}
}
