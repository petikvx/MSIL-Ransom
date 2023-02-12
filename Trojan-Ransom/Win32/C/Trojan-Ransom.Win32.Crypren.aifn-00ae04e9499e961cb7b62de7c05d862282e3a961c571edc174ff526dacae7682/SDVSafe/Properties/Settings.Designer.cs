using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet.Properties
{
	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000101BC File Offset: 0x0000E3BC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000101D4 File Offset: 0x0000E3D4
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000101F6 File Offset: 0x0000E3F6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("COM10")]
		public string COMPort
		{
			get
			{
				return (string)this["COMPort"];
			}
			set
			{
				this["COMPort"] = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00010208 File Offset: 0x0000E408
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0001022A File Offset: 0x0000E42A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool TabEnabled
		{
			get
			{
				return (bool)this["TabEnabled"];
			}
			set
			{
				this["TabEnabled"] = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00010240 File Offset: 0x0000E440
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00010262 File Offset: 0x0000E462
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public string StoreID
		{
			get
			{
				return (string)this["StoreID"];
			}
			set
			{
				this["StoreID"] = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00010274 File Offset: 0x0000E474
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00010296 File Offset: 0x0000E496
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string StoreName
		{
			get
			{
				return (string)this["StoreName"];
			}
			set
			{
				this["StoreName"] = value;
			}
		}

		// Token: 0x04000116 RID: 278
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
