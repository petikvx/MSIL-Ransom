using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Security;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace clen.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	private static bool bool_0;

	private static object object_0;

	public static MySettings Default
	{
		get
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			if (!bool_0)
			{
				object gparam_ = object_0;
				Class6.smethod_3(gparam_, 205, 218);
				bool flag = false;
				try
				{
					Class3.Class5.smethod_0(gparam_, ref flag, 113, 96);
					if (!bool_0)
					{
						Class3.smethod_9<WindowsFormsApplicationBase, ShutdownEventHandler>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, new ShutdownEventHandler(smethod_0), '\u0350', '\u033c');
						bool_0 = true;
					}
				}
				finally
				{
					if (flag)
					{
						Class6.smethod_3(gparam_, 845, 853);
					}
				}
			}
			return (MySettings)(SettingsBase)mySettings_0;
		}
	}

	[SecuritySafeCritical]
	static MySettings()
	{
		Class6.smethod_1();
		mySettings_0 = (MySettings)(object)Class3.Class5.smethod_1<SettingsBase>((SettingsBase)(object)new MySettings(), 109, 18);
		object_0 = Class6.smethod_2(new object(), 'Ğ', 319);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (Class6.Class7.smethod_0<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, (short)648, 733))
		{
			Class6.Class7.smethod_1<ApplicationSettingsBase>((ApplicationSettingsBase)(object)Class9.MySettings_0, (short)412, 385);
		}
	}
}
