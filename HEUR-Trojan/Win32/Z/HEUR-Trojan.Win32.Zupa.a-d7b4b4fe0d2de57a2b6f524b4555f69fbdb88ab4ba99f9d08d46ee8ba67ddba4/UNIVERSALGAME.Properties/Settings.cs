using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UNIVERSALGAME.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("8")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int HP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050226890));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050226890), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Q")]
	[UserScopedSetting]
	public string HP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050226937));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050226937), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("8")]
	public int SP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050226921));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050226921), (object)value);
		}
	}

	[DefaultSettingValue("W")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string SP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050226952));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050226952), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("E")]
	public string Wing_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227000));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227000), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int Macro1_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050226982));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050226982), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("T")]
	public string Macro1_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227028));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227028), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int Macro2_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227024));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227024), (object)value);
		}
	}

	[DefaultSettingValue("Y")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Macro2_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227070));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227070), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int AB_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227050));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227050), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int ATK_Skill
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227100));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227100), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("4")]
	[DebuggerNonUserCode]
	public int Over_Weight
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227084));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227084), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection Monster_List
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227130));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227130), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection Item_List
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227159));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227159), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int Macro3_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227143));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227143), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("U")]
	[DebuggerNonUserCode]
	public string Macro3_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227189));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227189), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int HP_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050227169));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050227169), (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Username
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221073));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221073), (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Password
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221058));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221058), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int SKILLBUFF_1
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221107));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221107), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int SKILLBUFF_2
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221089));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221089), (object)value);
		}
	}

	[DefaultSettingValue("74")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int SKILLBUFF_3
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221151));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221151), (object)value);
		}
	}

	[DefaultSettingValue("74")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int SKILLBUFF_4
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221133));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221133), (object)value);
		}
	}

	[DefaultSettingValue("74")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int SKILLBUFF_5
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221179));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221179), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("74")]
	[UserScopedSetting]
	public int SKILLBUFF_6
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221161));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221161), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int SKILLBUFF_1_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221191));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221191), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int SKILLBUFF_2_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221248));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221248), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int SKILLBUFF_3_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221225));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221225), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int SKILLBUFF_4_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221250));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221250), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int SKILLBUFF_5_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221307));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221307), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int SKILLBUFF_6_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221332));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221332), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection Monster_Escape_List
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221325));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221325), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int ATK_Skill_Lv
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221347));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221347), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int Macro4_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221408));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221408), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("I")]
	public string Macro4_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221390));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221390), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int Scrum_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221434));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221434), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string SKILLBUFF_ADDRESS
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221463));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221463), (object)value);
		}
	}

	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int Delay_System
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221455));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221455), (object)value);
		}
	}

	[DefaultSettingValue("8")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _2_HP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221500));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221500), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Q")]
	[UserScopedSetting]
	public string _2_HP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221528));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221528), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("8")]
	public int _2_SP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221509));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221509), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("W")]
	public string _2_SP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221553));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221553), (object)value);
		}
	}

	[DefaultSettingValue("E")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string _2_Wing_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221550));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221550), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_Macro1_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221593));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221593), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("R")]
	[UserScopedSetting]
	public string _2_Macro1_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221620));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221620), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int _2_Macro2_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221613));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221613), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("T")]
	[UserScopedSetting]
	public string _2_Macro2_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221640));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221640), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _2_AB_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221681));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221681), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _2_ATK_Skill
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221680));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221680), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("4")]
	public int _2_Over_Weight
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221725));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221725), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_Macro3_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221752));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221752), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("Y")]
	[DebuggerNonUserCode]
	public string _2_Macro3_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221731));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221731), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_HP_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221788));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221788), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _2_SKILLBUFF_1
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221769));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221769), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int _2_SKILLBUFF_2
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221796));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221796), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("74")]
	public int _2_SKILLBUFF_3
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221855));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221855), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("74")]
	public int _2_SKILLBUFF_4
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221834));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221834), (object)value);
		}
	}

	[DefaultSettingValue("74")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _2_SKILLBUFF_5
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221861));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221861), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("74")]
	[DebuggerNonUserCode]
	public int _2_SKILLBUFF_6
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221920));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221920), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _2_SKILLBUFF_1_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221899));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221899), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _2_SKILLBUFF_2_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221921));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221921), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _2_SKILLBUFF_3_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221959));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221959), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int _2_SKILLBUFF_4_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222013));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222013), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_SKILLBUFF_5_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222035));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222035), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int _2_SKILLBUFF_6_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222025));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222025), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_ATK_Skill_Lv
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222063));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222063), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _2_Macro4_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220057));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220057), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("U")]
	public string _2_Macro4_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220084));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220084), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_Scrum_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220077));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220077), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	public int _2_Delay_System
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220103));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220103), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	public int _3_HP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220145));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220145), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("Q")]
	[DebuggerNonUserCode]
	public string _3_HP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220141));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220141), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("8")]
	public int _3_SP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220186));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220186), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("W")]
	public string _3_SP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220214));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220214), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("E")]
	[DebuggerNonUserCode]
	public string _3_Wing_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220195));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220195), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_Macro1_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220254));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220254), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("R")]
	public string _3_Macro1_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220233));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220233), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_Macro2_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220258));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220258), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("T")]
	public string _3_Macro2_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220317));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220317), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_AB_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220342));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220342), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _3_ATK_Skill
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220325));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220325), (object)value);
		}
	}

	[DefaultSettingValue("4")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_Over_Weight
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220370));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220370), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _3_Macro3_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220365));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220365), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Y")]
	public string _3_Macro3_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220392));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220392), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _3_HP_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220433));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220433), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_SKILLBUFF_1
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220430));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220430), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _3_SKILLBUFF_2
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220473));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220473), (object)value);
		}
	}

	[DefaultSettingValue("74")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_SKILLBUFF_3
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220500));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220500), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("74")]
	public int _3_SKILLBUFF_4
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220495));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220495), (object)value);
		}
	}

	[DefaultSettingValue("74")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_SKILLBUFF_5
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220538));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220538), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("74")]
	public int _3_SKILLBUFF_6
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220565));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220565), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _3_SKILLBUFF_1_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220560));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220560), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_SKILLBUFF_2_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220582));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220582), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _3_SKILLBUFF_3_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220636));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220636), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_SKILLBUFF_4_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220658));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220658), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_SKILLBUFF_5_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220696));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220696), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_SKILLBUFF_6_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220686));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220686), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int _3_ATK_Skill_Lv
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220708));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220708), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _3_Macro4_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220766));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220766), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("U")]
	[UserScopedSetting]
	public string _3_Macro4_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220745));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220745), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_Scrum_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220770));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220770), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	public int _3_Delay_System
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220828));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220828), (object)value);
		}
	}

	[DefaultSettingValue("1")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int Server_Index
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220854));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220854), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public StringCollection ROWAR_Friend_List
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220835));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220835), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Q")]
	public string ROWAR_HP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220891));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220891), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ROWAR_HP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220917));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220917), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Q")]
	public string ROLOOT_HP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220910));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220910), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ROLOOT_HP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220935));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220935), (object)value);
		}
	}

	[DefaultSettingValue("W")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string ROLOOT_SP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050220991));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050220991), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ROLOOT_SP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221016));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221016), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public StringCollection ROLOOT_Item_List
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221008));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221008), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Lock_Target
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050221049));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050221049), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int ROSUPPORT_HP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223133));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223133), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ROSUPPORT_Call_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223154));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223154), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int ROLOOT_Speed
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223192));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223192), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("W")]
	[DebuggerNonUserCode]
	public string ROWAR_SP_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223173));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223173), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int ROWAR_SP_Percent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223231));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223231), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Q")]
	public string ROSUPPORT_Call_Heal_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223256));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223256), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("O")]
	[UserScopedSetting]
	public string BWing_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223287));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223287), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("O")]
	[UserScopedSetting]
	public string _2_BWing_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223268));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223268), (object)value);
		}
	}

	[DefaultSettingValue("O")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string _3_BWing_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223326));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223326), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string Path_Map
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223352));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223352), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string _2_Path_Map
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223353));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223353), (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string _3_Path_Map
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223383));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223383), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ATK_Skill_Mode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223365));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223365), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int _2_ATK_Skill_Mode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223424));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223424), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_ATK_Skill_Mode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223448));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223448), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int ATK_Floor_Skill
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223440));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223440), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int _2_ATK_Floor_Skill
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223482));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223482), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _3_ATK_Floor_Skill
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223505));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223505), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ATK_Floor_Skill_Lv
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223544));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223544), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _2_ATK_Floor_Skill_Lv
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223535));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223535), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _3_ATK_Floor_Skill_Lv
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223555));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223555), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int ATK_Floor_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223591));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223591), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int _2_ATK_Floor_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223634));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223634), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int _3_ATK_Floor_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223626));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223626), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Self_AB_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223650));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223650), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int ROSUPPORT_Self_Kyrie_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223685));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223685), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ROSUPPORT_Target_AB_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223717));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223717), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ROSUPPORT_Target_Kyrie_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223750));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223750), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ROSUPPORT_Target_ImpositoManus_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223780));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223780), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Party_Gloria_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223818));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223818), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int ROSUPPORT_Party_Magnificat_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223896));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223896), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Party_AB_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223922));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223922), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int ROSUPPORT_Party_Kyrie_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223956));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223956), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Party_Heal_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050223987));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050223987), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int Setting
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050224019));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050224019), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public StringCollection Home_Settings
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050224005));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050224005), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public StringCollection _2_Home_Settings
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050224049));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050224049), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public StringCollection _3_Home_Settings
	{
		get
		{
			return (StringCollection)((SettingsBase)this).get_Item(Class60.smethod_0(-2050224042));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050224042), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ATK_Floor_Skill_X
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050224067));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050224067), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int ATK_Floor_Skill_Y
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050224123));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050224123), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _2_ATK_Floor_Skill_X
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222099));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222099), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _2_ATK_Floor_Skill_Y
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222136));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222136), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int _3_ATK_Floor_Skill_X
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222125));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222125), (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_ATK_Floor_Skill_Y
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222146));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222146), (object)value);
		}
	}

	[DefaultSettingValue("2")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int HP_Sitdown
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222183));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222183), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("2")]
	[UserScopedSetting]
	public int _2_HP_Sitdown
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222230));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222230), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("2")]
	public int _3_HP_Sitdown
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222210));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222210), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("2")]
	[DebuggerNonUserCode]
	public int SP_Sitdown
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222270));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222270), (object)value);
		}
	}

	[DefaultSettingValue("2")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _2_SP_Sitdown
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222253));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222253), (object)value);
		}
	}

	[DefaultSettingValue("2")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_SP_Sitdown
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222297));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222297), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string Line_Token
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222325));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222325), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int ATK_Floor_Skill_Mode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222308));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222308), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int _2_ATK_Floor_Skill_Mode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222361));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222361), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int _3_ATK_Floor_Skill_Mode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222395));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222395), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Self_Sacrament_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222429));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222429), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int ROSUPPORT_Target_Sacrament_Freq
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222457));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222457), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("8")]
	[UserScopedSetting]
	public int Monster_Over_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222467));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222467), (object)value);
		}
	}

	[DefaultSettingValue("8")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int _2_Monster_Over_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222521));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222521), (object)value);
		}
	}

	[DefaultSettingValue("8")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int _3_Monster_Over_Escape
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222556));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222556), (object)value);
		}
	}

	[DefaultSettingValue("A")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Arrow_Box_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222591));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222591), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("S")]
	public string Arrow_Hotkey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222616));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222616), (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int Distance_Attack
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(Class60.smethod_0(-2050222597));
		}
		set
		{
			((SettingsBase)this).set_Item(Class60.smethod_0(-2050222597), (object)value);
		}
	}
}
